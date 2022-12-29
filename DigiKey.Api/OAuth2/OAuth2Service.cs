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

using OriginalCircuit.DigiKey.Api.Configuration;
using OriginalCircuit.DigiKey.Api.OAuth2.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace OriginalCircuit.DigiKey.Api.OAuth2
{
    /// <summary>
    /// OAuth2Service accepts ApiApiClientConfigHelper.Instance to use to initialize and finish an OAuth2 Authorization and 
    /// get and set the Access Token and Refresh Token for the given ClientId and Client Secret in the ApiApiClientConfigHelper.Instance
    /// </summary>
    public class OAuth2Service
    {

        public OAuth2Service()
        {
        }

        /// <summary>
        /// Generates the authentication URL based on ApiApiClientConfigHelper.Instance.
        /// </summary>
        /// <param name="scopes">This is current not used and should be "".</param>
        /// <param name="state">This is not currently used.</param>
        /// <returns>string which is the oauth2 authorization url.</returns>
        public string GenerateAuthUrl(string scopes = "", string state = null)
        {
            string baseAddress = ApiClientConfig.Instance.BaseAddress.EndsWith("/") ? ApiClientConfig.Instance.BaseAddress.TrimEnd('/') : ApiClientConfig.Instance.BaseAddress;
            
            var url = $"{baseAddress}{ApiClientConfig.AuthorizationEndpoint}?client_id={ApiClientConfig.Instance.ClientId}&scope={scopes}&redirect_uri={HttpUtility.UrlEncode(ApiClientConfig.Instance.RedirectUri)}&response_type=code";

            if (!string.IsNullOrWhiteSpace(state))
            {
                url = $"{url}&state={state}";
            }

            return url;
        }

        /// <summary>
        /// Finishes authorization by passing the authorization code to the Token endpoint
        /// </summary>
        /// <param name="code">Code value returned by the RedirectUri callback</param>
        /// <returns>Returns OAuth2AccessToken</returns>
        public async Task<OAuth2AccessToken> FinishAuthorization(string code)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };


            var client = new RestClient(ApiClientConfig.Instance.BaseAddress);
            var request = new RestRequest(ApiClientConfig.TokenEndpoint)
                .AddParameter("code", code)
                .AddParameter("redirect_uri", ApiClientConfig.Instance.RedirectUri)
                .AddParameter("grant_type", "authorization_code")
                .AddParameter("client_id", ApiClientConfig.Instance.ClientId)
                .AddParameter("client_secret", ApiClientConfig.Instance.ClientSecret);

            // todo: test PostAsync<OAuth2AccessToken>
            var response = await client.PostAsync(request);
            var text = response.Content;

            // Check if there was an error in the response
            if (!response.IsSuccessful)
            {
                var status = response.StatusCode;
                if (status == HttpStatusCode.BadRequest)
                {
                    // Deserialize and return model
                    var errorResponse = JsonConvert.DeserializeObject<OAuth2AccessToken>(text);
                    return errorResponse;
                }

                // Throw error
                if (response.ErrorException != null) throw response.ErrorException;
                throw new Exception(response.ErrorMessage);
            }

            // Deserializes the token response if successfull
            var oAuth2Token = OAuth2Helpers.ParseOAuth2AccessTokenResponse(text);

            return oAuth2Token;
        }
    }
}
