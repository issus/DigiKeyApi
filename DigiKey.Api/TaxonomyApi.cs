
using DigiKey.Api.Client;
using RestSharp;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DigiKey.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITaxonomyApi
    {
        /// <summary>
        /// Retrieves a URL to a filtered partsearch page. Any filter names and values may be used as query parameters as long as it exists for the category. For example: \&quot;color&#x3D;black\&quot;. However, these cannot be entered on the Swagger page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Category name to filter within. If the category has a parent it can be included as \&quot;parent:child\&quot;. If no parent is provided, only child categories are searched. Note that some child categories exist in multiple parents.</param>
        /// <param name="authorization">OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info.</param>
        /// <param name="xDIGIKEYClientId">The Client Id for your App.</param>
        /// <returns>string</returns>
        Task<string> TaxonomySearch(string category);

        /// <summary>
        /// Retrieves a URL to a filtered partsearch page. Any filter names and values may be used as query parameters as long as it exists for the category. For example: \&quot;color&#x3D;black\&quot;. However, these cannot be entered on the Swagger page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Category name to filter within. If the category has a parent it can be included as \&quot;parent:child\&quot;. If no parent is provided, only child categories are searched. Note that some child categories exist in multiple parents.</param>
        /// <param name="authorization">OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info.</param>
        /// <param name="xDIGIKEYClientId">The Client Id for your App.</param>
        /// <returns>ApiResponse of string</returns>
        Task<ApiResponse<string>> TaxonomySearchWithHttpInfo(string category);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TaxonomyApi : BaseApi, ITaxonomyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxonomyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TaxonomyApi()
        {
        }

        /// <summary>
        /// Retrieves a URL to a filtered partsearch page. Any filter names and values may be used as query parameters as long as it exists for the category. For example: \&quot;color&#x3D;black\&quot;. However, these cannot be entered on the Swagger page. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Category name to filter within. If the category has a parent it can be included as \&quot;parent:child\&quot;. If no parent is provided, only child categories are searched. Note that some child categories exist in multiple parents.</param>
        /// <param name="authorization">OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info.</param>
        /// <param name="xDIGIKEYClientId">The Client Id for your App.</param>
        /// <returns>string</returns>
        public async Task<string> TaxonomySearch(string category)
        {
            ApiResponse<string> localVarResponse = await TaxonomySearchWithHttpInfo(category);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a URL to a filtered partsearch page. Any filter names and values may be used as query parameters as long as it exists for the category. For example: \&quot;color&#x3D;black\&quot;. However, these cannot be entered on the Swagger page. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="category">Category name to filter within. If the category has a parent it can be included as \&quot;parent:child\&quot;. If no parent is provided, only child categories are searched. Note that some child categories exist in multiple parents.</param>
        /// <param name="authorization">OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info.</param>
        /// <param name="xDIGIKEYClientId">The Client Id for your App.</param>
        /// <returns>ApiResponse of string</returns>
        public async Task<ApiResponse<string>> TaxonomySearchWithHttpInfo(string category)
        {
            // verify the required parameter 'category' is set
            if (category == null)
                throw new ApiException(400, "Missing required parameter 'category' when calling TaxonomyApi->TaxonomySearch");

            var path = "/taxonomysearch/v3/{category}";
            RestResponse response = await MakeGetRequest(path);

            int statusCode = (int)response.StatusCode;

            if (ApiClient.ExceptionFactory != null)
            {
                Exception exception = ApiClient.ExceptionFactory("TaxonomySearch", response);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(statusCode, response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
               ApiClient.Instance.Deserialize<string>(response));
        }
    }
}
