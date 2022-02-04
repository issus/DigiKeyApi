using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using DigiKey.Api.Client;
using DigiKey.Api.Model;
using System.Threading.Tasks;

namespace DigiKey.Api
{
    

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RecommendedProductsApi : BaseApi, IRecommendedProductsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendedProductsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RecommendedProductsApi()
        {
        }

        /// <summary>
        /// Returns a list of recommended products for the given part number. 
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The part being searched for</param>
        /// <param name="authorization">OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info.</param>
        /// <param name="xDIGIKEYClientId">The Client Id for your App.</param>
        /// <param name="recordCount">The number of records to be returned (optional, default to 1)</param>
        /// <param name="searchOptionList">A comma delimited list of filters that can be used to limit results. Available filters are the following: LeadFree, CollapsePackingTypes, ExcludeNonStock, Has3DModel, InStock, ManufacturerPartSearch, NewProductsOnly, RoHSCompliant. (optional)</param>
        /// <param name="excludeMarketPlaceProducts">Used to exclude MarkPlace products from search results. Default is false (optional, default to false)</param>
        /// <param name="includes">Comma separated list of fields to return. Used to customize response to reduce bandwidth by selecting fields that you wish to receive. For example: \&quot;RecommendedProductsCollection(RecommendedProducts(DigiKeyPartNumber,ManufacturerPartNumber))\&quot; (optional)</param>
        /// <param name="xDIGIKEYLocaleSite">Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. (optional)</param>
        /// <param name="xDIGIKEYLocaleLanguage">Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. (optional)</param>
        /// <param name="xDIGIKEYLocaleCurrency">Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. (optional)</param>
        /// <param name="xDIGIKEYLocaleShipToCountry">ISO code for country to ship to. (optional)</param>
        /// <returns>RecommendedProductsResponse</returns>
        public async Task<RecommendedProductsResponse> RecommendedProducts (string digiKeyPartNumber)
        {
             ApiResponse<RecommendedProductsResponse> localVarResponse = await RecommendedProductsWithHttpInfo(digiKeyPartNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of recommended products for the given part number. 
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The part being searched for</param>
        /// <param name="authorization">OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info.</param>
        /// <param name="xDIGIKEYClientId">The Client Id for your App.</param>
        /// <param name="recordCount">The number of records to be returned (optional, default to 1)</param>
        /// <param name="searchOptionList">A comma delimited list of filters that can be used to limit results. Available filters are the following: LeadFree, CollapsePackingTypes, ExcludeNonStock, Has3DModel, InStock, ManufacturerPartSearch, NewProductsOnly, RoHSCompliant. (optional)</param>
        /// <param name="excludeMarketPlaceProducts">Used to exclude MarkPlace products from search results. Default is false (optional, default to false)</param>
        /// <param name="includes">Comma separated list of fields to return. Used to customize response to reduce bandwidth by selecting fields that you wish to receive. For example: \&quot;RecommendedProductsCollection(RecommendedProducts(DigiKeyPartNumber,ManufacturerPartNumber))\&quot; (optional)</param>
        /// <param name="xDIGIKEYLocaleSite">Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. (optional)</param>
        /// <param name="xDIGIKEYLocaleLanguage">Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. (optional)</param>
        /// <param name="xDIGIKEYLocaleCurrency">Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. (optional)</param>
        /// <param name="xDIGIKEYLocaleShipToCountry">ISO code for country to ship to. (optional)</param>
        /// <returns>ApiResponse of RecommendedProductsResponse</returns>
        public async Task<ApiResponse<RecommendedProductsResponse>> RecommendedProductsWithHttpInfo (string digiKeyPartNumber)
        {
            // verify the required parameter 'digiKeyPartNumber' is set
            if (digiKeyPartNumber == null)
                throw new ApiException(400, "Missing required parameter 'digiKeyPartNumber' when calling RecommendedProductsApi->RecommendedProducts");
            
            var path = $"/Recommendations/v3/Products/{digiKeyPartNumber}";
            RestResponse response = await MakeGetRequest(path);

            int statusCode = (int)response.StatusCode;

            if (ApiClient.ExceptionFactory != null)
            {
                Exception exception = ApiClient.ExceptionFactory("RecommendedProducts", response);
                if (exception != null && !(statusCode == 429 && !ApiClient.Instance.ThrowRateLimitExceptions)) throw exception;
            }

            return new ApiResponse<RecommendedProductsResponse>(statusCode, response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
               ApiClient.Instance.Deserialize<RecommendedProductsResponse>(response));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRecommendedProductsApi
    {
        /// <summary>
        /// Returns a list of recommended products for the given part number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The part being searched for</param>
        /// <returns>RecommendedProductsResponse</returns>
        Task<RecommendedProductsResponse> RecommendedProducts(string digiKeyPartNumber);

        /// <summary>
        /// Returns a list of recommended products for the given part number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The part being searched for</param>
        /// <returns>ApiResponse of RecommendedProductsResponse</returns>
        Task<ApiResponse<RecommendedProductsResponse>> RecommendedProductsWithHttpInfo(string digiKeyPartNumber);
    }
}
