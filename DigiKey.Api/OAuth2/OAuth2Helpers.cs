//-----------------------------------------------------------------------
//
// THE SOFTWARE IS PROVIDED "AS IS" WITHOUT ANY WARRANTIES OF ANY KIND, EXPRESS, IMPLIED, STATUTORY, 
// OR OTHERWISE. EXPECT TO THE EXTENT PROHIBITED BY APPLICABLE LAW, DIGI-KEY DISCLAIMS ALL WARRANTIES, 
// INCLUDING, WITHOUT LIMITATION, ANY IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, 
// SATISFACTORY QUALITY, TITLE, NON-INFRINGEMENT, QUIET ENJOYMENT, 
// AND WARRANTIES ARISING OUT OF ANY COURSE OF DEALING OR USAGE OF TRADE. 
// 
// DIGI-KEY DOES NOT WARRANT THAT THE SOFTWARE WILL FUNCTION AS DESCRIBED, 
// WILL BE UNINTERRUPTED OR ERROR-FREE, OR FREE OF HARMFUL COMPONENTS.
// 
//-----------------------------------------------------------------------

using DigiKey.Api.Client;
using DigiKey.Api.Configuration;
using DigiKey.Api.OAuth2.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;

namespace DigiKey.Api.OAuth2
{
    /// <summary>
    /// Helper functions for OAuth2Service class and other classes calling OAuth2Service functions
    /// </summary>
    public static class OAuth2Helpers
    {
        /// <summary>
        /// Determines whether response has a unauthorized error message.
        /// </summary>
        /// <param name="content">json response</param>
        /// <returns>
        /// <c>true</c> if token is stale in the error response; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsTokenStale(string content)
        {
            var errors = JsonConvert.DeserializeObject<OAuth2Error>(content);
            return errors.HttpMessage.ToLower().Contains("unauthorized");
        }

        /// <summary>
        /// Refreshes the token asynchronous.
        /// </summary>
        /// <returns>Returns OAuth2AccessToken</returns>
        public static async Task<OAuth2AccessToken> RefreshTokenAsync()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var client = new RestClient(ApiClientConfig.Instance.BaseAddress);
            var request = new RestRequest(ApiClientConfig.TokenEndpoint)
                .AddParameter("grant_type", "refresh_token")
                .AddParameter("client_id", ApiClientConfig.Instance.ClientId)
                .AddParameter("client_secret", ApiClientConfig.Instance.ClientSecret)
                .AddParameter("refresh_token", ApiClientConfig.Instance.RefreshToken);

            // todo: test PostAsync<OAuth2AccessToken>
            var response = await client.PostAsync(request);
            var responseString = response.Content;

            var oAuth2AccessToken = OAuth2Helpers.ParseOAuth2AccessTokenResponse(responseString);

            ApiClientConfig.Instance.AccessToken = oAuth2AccessToken.AccessToken;
            ApiClientConfig.Instance.RefreshToken = oAuth2AccessToken.RefreshToken;
            ApiClientConfig.Instance.ExpirationDateTime = DateTime.Now.AddSeconds(oAuth2AccessToken.ExpiresIn);

            ApiClientConfig.Instance.Save();

            return oAuth2AccessToken;
        }

        /// <summary>
        /// Parses the OAuth2 access token response.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns>instance of OAuth2AccessToken</returns>
        /// <exception cref="ApiException">ull)</exception>
        public static OAuth2AccessToken ParseOAuth2AccessTokenResponse(string response)
        {
            try
            {
                var oAuth2AccessTokenResponse = JsonConvert.DeserializeObject<OAuth2AccessToken>(response);
                return oAuth2AccessTokenResponse;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
                throw new ApiException(0, $"Unable to parse OAuth2 access token response {e.Message}", null);
            }
        }
    }
}
