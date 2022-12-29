using OriginalCircuit.DigiKey.Api.Configuration;
using OriginalCircuit.DigiKey.Api.OAuth2;
using System;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OriginalCircuit.DigiKey.Api.OAuth2ConsoleClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // This console client is strongly based on the ideas from Digi-Key's API OAuth2 client:
            // https://github.com/Digi-Key/ApiClient.V3

            var oAuth2Service = new OAuth2Service();
            var authUrl = oAuth2Service.GenerateAuthUrl("");

            var processInfo = new ProcessStartInfo(authUrl) { UseShellExecute = true };
            Process.Start(processInfo);

            using (var httpListener = new HttpListener())
            {
                var localUrl = ApiClientConfig.Instance.RedirectUri.EndsWith("/") ? ApiClientConfig.Instance.RedirectUri : ApiClientConfig.Instance.RedirectUri + "/";
                httpListener.Prefixes.Add(localUrl);
                Console.WriteLine($"listening to {ApiClientConfig.Instance.RedirectUri}");
                Console.WriteLine();
                httpListener.Start();

                var context = await httpListener.GetContextAsync();
                HttpListenerResponse response = context.Response;

                var queryString = context.Request.Url.Query;
                var code = HttpUtility.ParseQueryString(queryString)["code"];
                var result = await oAuth2Service.FinishAuthorization(code);

                if (result.IsError)
                {
                    Console.WriteLine("Failed to retrieve token.");
                    Console.WriteLine($"Error      : {result.Error}");
                    Console.WriteLine($"Description: {result.ErrorDescription}");

                    await SendErrorResponse(response, result.Error, result.ErrorDescription);
                }
                else
                {
                    ApiClientConfig.Instance.AccessToken = result.AccessToken;
                    ApiClientConfig.Instance.RefreshToken = result.RefreshToken;
                    ApiClientConfig.Instance.ExpirationDateTime = DateTime.Now.AddSeconds(result.ExpiresIn);

                    Console.WriteLine("Successfully retrieved token!");
                    ApiClientConfig.Instance.Save();

                    Console.WriteLine("Token details saved.");

                    await SendApiClientResponse(response);

                    Console.WriteLine();
                    Console.WriteLine($"Access token : {result.AccessToken}");
                    Console.WriteLine($"Refresh token: {result.RefreshToken}");
                    Console.WriteLine($"Expires in   : {result.ExpiresIn} seconds");
                }
                
                httpListener.Stop();
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press [Any Key] to exit...");
            Console.ReadKey();
        }

        private static async Task SendErrorResponse(HttpListenerResponse response, string error, string description)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(
                $"<html><body><h1>Error During OAuth2</h1><hr /><p><strong>Error:</strong>{error}</p><strong>Description:</strong>{description}</p></body></html>"
                );

            response.ContentLength64 = buffer.Length;
            System.IO.Stream output = response.OutputStream;
            await output.WriteAsync(buffer, 0, buffer.Length);
            output.Close();
        }


        private static async Task SendApiClientResponse(HttpListenerResponse response)
        {
            StringBuilder responseContent = new StringBuilder();
            responseContent.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            responseContent.AppendLine("<configuration>");
            responseContent.AppendLine("  <appSettings file=\"\">");
            responseContent.AppendLine("    <clear/>");
            responseContent.AppendLine($"    <add key=\"ApiClient.ClientId\" value=\"{ApiClientConfig.Instance.ClientId}\" />");
            responseContent.AppendLine($"    <add key=\"ApiClient.ClientSecret\" value=\"{ApiClientConfig.Instance.ClientSecret}\" />");
            responseContent.AppendLine($"    <add key=\"ApiClient.RedirectUri\" value=\"{ApiClientConfig.Instance.RedirectUri}\" />");
            responseContent.AppendLine($"    <add key=\"ApiClient.AccessToken\" value=\"{ApiClientConfig.Instance.AccessToken}\" />");
            responseContent.AppendLine($"    <add key=\"ApiClient.RefreshToken\" value=\"{ApiClientConfig.Instance.RefreshToken}\" />");
            responseContent.AppendLine($"    <add key=\"ApiClient.ExpirationDateTime\" value=\"{ApiClientConfig.Instance.ExpirationDateTime.ToString("o")}\" />");
            responseContent.AppendLine($"    <add key=\"ApiClient.BaseAddress\" value=\"{ApiClientConfig.Instance.BaseAddress}\" />");
            responseContent.AppendLine("  </appSettings>");
            responseContent.AppendLine("</configuration>");
            HttpUtility.HtmlEncode(responseContent);

            byte[] buffer = Encoding.UTF8.GetBytes("<html><body><h1>apiclient.config</h1><hr /><pre>" + HttpUtility.HtmlEncode(responseContent) + "</pre></body></html>");

            response.ContentLength64 = buffer.Length;
            System.IO.Stream output = response.OutputStream;
            await output.WriteAsync(buffer, 0, buffer.Length);
            output.Close();
        }
    }
}
