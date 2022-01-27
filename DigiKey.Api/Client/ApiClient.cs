using DigiKey.Api.Configuration;
using DigiKey.Api.OAuth2;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DigiKey.Api.Client
{
    /// <summary>
    /// API client is mainly responsible for making the HTTP call to the API backend.
    /// </summary>
    public partial class ApiClient
    {
        private static Lazy<ApiClient> lazyInstance = new Lazy<ApiClient>(() => new ApiClient());

        public static ApiClient Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        public LocaleSite? LocaleSite { get; set; }
        public LocaleLanguage? LocaleLanguage { get; set; }
        public LocaleCurrency? LocaleCurrency { get; set; }
        public string CustomerId { get; set; }

        private JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        };

        /// <summary>
        /// Allows for extending request processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        partial void InterceptRequest(RestRequest request);

        /// <summary>
        /// Allows for extending response processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        /// <param name="response">The RestSharp response object</param>
        partial void InterceptResponse(RestRequest request, RestResponse response);

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default configuration.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        public ApiClient()
        {
            RestClientOptions = new RestClientOptions(ApiClientConfig.Instance.BaseAddress) { };

            RestClient = new RestClient(RestClientOptions);
        }

        /// <summary>
        /// Gets or sets the RestClient.
        /// </summary>
        /// <value>An instance of the RestClient</value>
        private RestClient RestClient { get; set; }

        private RestClientOptions RestClientOptions { get; set; }

        private async Task<bool> RefreshTokenExpiry(bool forceRefresh = false)
        {
            if (ApiClientConfig.Instance.ExpirationDateTime < DateTime.Now || forceRefresh)
            {
                // Let's refresh the token
                var oAuth2Service = new OAuth2Service();
                var oAuth2AccessToken = await OAuth2Helpers.RefreshTokenAsync();

                if (oAuth2AccessToken.IsError)
                {
                    // Current Refresh token is invalid or expired 
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Makes the HTTP request(Sync).
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body(POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content Type of the request</param>
        /// <returns>Rest Response</returns>
        public async Task<RestResponse> CallApi(
            string path, RestSharp.Method method, List<KeyValuePair<string, string>> queryParams, Object postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> pathParams, string contentType = "application/json")
        {
            await RefreshTokenExpiry();

            var request = new RestRequest(path, method);

            if (pathParams != null)
            {
                // add path parameter, if any
                foreach (var param in pathParams)
                    request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);
            }

            if (headerParams != null)
            {
                // add header parameter, if any
                foreach (var param in headerParams)
                    request.AddHeader(param.Key, param.Value);
            }

            if (queryParams != null)
            {
                // add query parameter, if any
                foreach (var param in queryParams)
                    request.AddQueryParameter(param.Key, param.Value);
            }

            if (postBody != null) // http body(model or byte[]) parameter
            {
                request.AddJsonBody(postBody);
            }

            request.AddHeader("Authorization", "Bearer " + ParameterToString(ApiClientConfig.Instance.AccessToken));
            request.AddHeader("X-DIGIKEY-Client-Id", ParameterToString(ApiClientConfig.Instance.ClientId));
            if (LocaleSite.HasValue) request.AddHeader("X-DIGIKEY-Locale-Site", ParameterToString(LocaleSite));
            if (LocaleLanguage.HasValue) request.AddHeader("X-DIGIKEY-Locale-Language", ParameterToString(LocaleSite));
            if (LocaleCurrency.HasValue) request.AddHeader("X-DIGIKEY-Locale-Currency", ParameterToString(LocaleSite));
            if (!string.IsNullOrEmpty(CustomerId)) request.AddHeader("X-DIGIKEY-Customer-Id", ParameterToString(CustomerId));

            request.AddHeader("Content-Type", "application/json");

            // set user agent
            RestClientOptions.UserAgent = "github.com/issus/DigiKey.Api/1.0.0";

            InterceptRequest(request);
            var response = await RestClient.ExecuteAsync(request);
            InterceptResponse(request, response);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                if (OAuth2Helpers.IsTokenStale(response.Content))
                {
                    await RefreshTokenExpiry(true);

                    string staleToken = "Api-StaleTokenRetry";

                    if (!response.Request.Parameters.Any(p => p.Name == staleToken))
                    {
                        request.AddHeader(staleToken, staleToken);
                        request.AddOrUpdateHeader("Authorization", "Bearer " + ParameterToString(ApiClientConfig.Instance.AccessToken));

                        InterceptRequest(request);
                        response = await RestClient.ExecuteAsync(request);
                        InterceptResponse(request, response);
                    }
                    else
                    {
                        throw new ApiException(0, $"Inside method CallApi we received an unexpected stale token response - during the retry for a call whose token we just refreshed {response.StatusCode}");
                    }
                }
            }

            return response;
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string(default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter(header, path, query, form).</param>
        /// <returns>Formatted string.</returns>
        public string ParameterToString(object obj)
        {
            if (obj is DateTime)
                // Return a formatted date string
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return ((DateTime)obj).ToString("o");
            else if (obj is DateTimeOffset)
                // Return a formatted date string
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return ((DateTimeOffset)obj).ToString("o");
            else if (obj is IList)
            {
                var flattenedString = new StringBuilder();
                foreach (var param in (IList)obj)
                {
                    if (flattenedString.Length > 0)
                        flattenedString.Append(",");
                    flattenedString.Append(param);
                }
                return flattenedString.ToString();
            }
            else
                return Convert.ToString(obj);
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public T Deserialize<T>(RestResponse response)
        {
            var type = typeof(T);

            IReadOnlyCollection<HeaderParameter> headers = response.Headers;
            if (type == typeof(byte[])) // return byte array
            {
                return (T)(object)response.RawBytes;
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return (T)(object)DateTime.Parse(response.Content, null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(string) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return ConvertType<T>(response.Content);
            }

            // at this point, it must be a model(json)
            try
            {
                return JsonConvert.DeserializeObject<T>(response.Content, serializerSettings);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Serialize an input(model) into JSON string
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>JSON string.</returns>
        public static string Serialize(object obj)
        {
            try
            {
                return obj != null ? JsonConvert.SerializeObject(obj) : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Check if the given MIME is a JSON MIME.
        /// JSON MIME examples:
        ///    application/json
        ///    application/json; charset=UTF8
        ///    APPLICATION/JSON
        ///    application/vnd.company+json
        /// </summary>
        /// <param name="mime">MIME</param>
        /// <returns>Returns True if MIME type is json.</returns>
        public bool IsJsonMime(string mime)
        {
            var jsonRegex = new Regex("(?i)^(application/json|[^;/ \t]+/[^;/ \t]+[+]json)[ \t]*(;.*)?$");
            return mime != null && (jsonRegex.IsMatch(mime) || mime.Equals("application/json-patch+json"));
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON type exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'
        /// </summary>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        public string SelectHeaderContentType(string[] contentTypes)
        {
            if (contentTypes.Length == 0)
                return "application/json";

            foreach (var contentType in contentTypes)
            {
                if (IsJsonMime(contentType.ToLower()))
                    return contentType;
            }

            return contentTypes[0]; // use the first content type specified in 'consumes'
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them(joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public string SelectHeaderAccept(string[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return string.Join(",", accepts);
        }

        /// <summary>
        /// Dynamically cast the object into target type.
        /// </summary>
        /// <param name="fromObject">Object to be casted</param>
        /// <param name="toObject">Target type</param>
        /// <returns>Casted object</returns>
        public static T ConvertType<T>(object fromObject)
        {
            Type conversionType = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);
            return (T)Convert.ChangeType(fromObject, conversionType);
        }

        /// <summary>
        /// Default creation of exceptions for a given method name and response object
        /// </summary>
        public static readonly ExceptionFactory ExceptionFactory = (methodName, response) =>
        {
            var status = (int)response.StatusCode;
            if (status >= 400)
            {
                return new ApiException(status,
                    string.Format("Error calling {0}: {1}", methodName, response.Content),
                    response.Content);
            }
            if (status == 0)
            {
                return new ApiException(status,
                    string.Format("Error calling {0}: {1}", methodName, response.ErrorMessage), response.ErrorMessage);
            }
            return null;
        };
    }
}
