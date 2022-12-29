using OriginalCircuit.DigiKey.Api.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace OriginalCircuit.DigiKey.Api.Configuration
{
    public class ApiClientConfig : ConfigurationHelper, IApiClientConfigHelper
    {
        private static Lazy<IApiClientConfigHelper> lazy = new Lazy<IApiClientConfigHelper>(() => new ApiClientConfig());
        private static IApiClientConfigHelper userSet;

        private const string clientId = "ApiClient.ClientId";
        private const string clientSecret = "ApiClient.ClientSecret";
        private const string redirectUri = "ApiClient.RedirectUri";
        private const string accessToken = "ApiClient.AccessToken";
        private const string refreshToken = "ApiClient.RefreshToken";
        private const string expirationDateTime = "ApiClient.ExpirationDateTime";
        private const string baseAddress = "ApiClient.BaseAddress";

        private ApiClientConfig()
        {
            try
            {
                var baseDir = AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\');
                List<string> searchPaths = new List<string>();
                searchPaths.Add(baseDir);
                searchPaths.Add(Environment.CurrentDirectory);
                searchPaths.Add(Directory.GetCurrentDirectory());
                searchPaths.Add(Directory.GetParent(baseDir).FullName);
                searchPaths.Add(Directory.GetParent(baseDir).Parent.Parent.FullName);
                ///DigiKeyApi\OriginalCircuit.DigiKey.Api.ConsoleClient\bin\Debug\netcoreapp3.1\
                searchPaths.Add(Directory.GetParent(baseDir).Parent.Parent.Parent.FullName);

                string apiConfigPath = null;

                foreach (var path in searchPaths)
                {
                    try // some paths may be restricted access on production servers
                    {
                        if (File.Exists(Path.Combine(path, "apiclient.config")))
                        {
                            apiConfigPath = Path.Combine(path, "apiclient.config");
                            break;
                        }
                    }
                    finally
                    { }
                }

                if (apiConfigPath == null)
                {
                    throw new ApiException(0, $"Unable to locate apiclient.config in the search paths");
                }

                var map = new ExeConfigurationFileMap
                {
                    ExeConfigFilename = apiConfigPath
                };
                Console.WriteLine($"map.ExeConfigFilename {map.ExeConfigFilename}");
                config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
            }
            catch (System.Exception ex)
            {
                throw new ApiException(0, $"Error in ApiClientConfigHelper on opening up apiclient.config {ex.Message}");
            }
        }

        public static IApiClientConfigHelper Instance
        {
            get
            {
                if (userSet != null)
                    return userSet;

                // default if instance is not set
                return lazy.Value;
            }
            set
            {
                userSet = value;
            }
        }

        public static string TokenEndpoint => "/v1/oauth2/token";
        public static string AuthorizationEndpoint => "/v1/oauth2/authorize";

        /// <summary>
        /// ClientId for ApiClient usage
        /// </summary>
        public string ClientId
        {
            get { return GetAttribute(clientId); }
            set { Update(clientId, value); }
        }

        /// <summary>
        /// ClientSecret for ApiClient usage
        /// </summary>
        public string ClientSecret
        {
            get { return GetAttribute(clientSecret); }
            set { Update(clientSecret, value); }
        }

        /// <summary>
        /// RedirectUri for ApiClient usage
        /// </summary>
        public string RedirectUri
        {
            get { return GetAttribute(redirectUri); }
            set { Update(redirectUri, value); }
        }

        /// <summary>
        /// AccessToken for ApiClient usage
        /// </summary>
        public string AccessToken
        {
            get { return GetAttribute(accessToken); }
            set { Update(accessToken, value); }
        }

        /// <summary>
        /// RefreshToken for ApiClient usage
        /// </summary>
        public string RefreshToken
        {
            get { return GetAttribute(refreshToken); }
            set { Update(refreshToken, value); }
        }

        /// <summary>
        /// Client for ApiClient usage
        /// </summary>
        public DateTime ExpirationDateTime
        {
            get
            {
                var dateTime = GetAttribute(expirationDateTime);
                if (string.IsNullOrEmpty(dateTime))
                {
                    return DateTime.MinValue;
                }
                return DateTime.Parse(dateTime, null, DateTimeStyles.RoundtripKind);
            }
            set
            {
                var dateTime = value.ToString("o"); // "o" is "roundtrip"
                Update(expirationDateTime, dateTime);
            }
        }

        public string BaseAddress
        {
            get { return GetAttribute(baseAddress); }
            set { Update(baseAddress, value); }
        }
    }
}
