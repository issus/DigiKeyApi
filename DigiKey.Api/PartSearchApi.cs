using DigiKey.Api.Client;
using DigiKey.Api.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiKey.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PartSearchApi : BaseApi, IPartSearchApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartSearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PartSearchApi()
        {
        }
        /// <summary>
        /// Returns all Product Categories. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category 
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info.</param>
        /// <param name="xDIGIKEYClientId">The Client Id for your App.</param>
        /// <param name="xDIGIKEYLocaleSite">Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH.(optional)</param>
        /// <param name="xDIGIKEYLocaleLanguage">Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no.(optional)</param>
        /// <param name="xDIGIKEYLocaleCurrency">Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP.(optional)</param>
        /// <param name="xDIGIKEYCustomerId">Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them.(optional)</param>
        /// <returns>CategoriesResponse</returns>
        public async Task<CategoriesResponse> Categories()
        {
            ApiResponse<CategoriesResponse> localVarResponse = await CategoriesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns all Product Categories. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category 
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info.</param>
        /// <param name="xDIGIKEYClientId">The Client Id for your App.</param>
        /// <param name="xDIGIKEYLocaleSite">Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH.(optional)</param>
        /// <param name="xDIGIKEYLocaleLanguage">Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no.(optional)</param>
        /// <param name="xDIGIKEYLocaleCurrency">Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP.(optional)</param>
        /// <param name="xDIGIKEYCustomerId">Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them.(optional)</param>
        /// <returns>ApiResponse of CategoriesResponse</returns>
        public async Task<ApiResponse<CategoriesResponse>> CategoriesWithHttpInfo()
        {
            var path = "/Search/v3/Categories";
            RestResponse response = await MakeGetRequest(path);

            int statusCode = (int)response.StatusCode;

            if (ApiClient.ExceptionFactory != null)
            {
                Exception exception = ApiClient.ExceptionFactory("Categories", response);
                if (exception != null && !(statusCode == 429 && !ApiClient.Instance.ThrowRateLimitExceptions)) throw exception;
            }

            return new ApiResponse<CategoriesResponse>(statusCode, response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
               ApiClient.Instance.Deserialize<CategoriesResponse>(response));
        }

        /// <summary>
        /// Returns Category for given Id. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category 
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId"></param>
        /// <returns>Category</returns>
        public async Task<Category> CategoriesById(int? categoryId)
        {
            ApiResponse<Category> localVarResponse = await CategoriesByIdWithHttpInfo(categoryId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns Category for given Id. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category 
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId"></param>
        /// <returns>ApiResponse of Category</returns>
        public async Task<ApiResponse<Category>> CategoriesByIdWithHttpInfo(int? categoryId)
        {
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling PartSearchApi->CategoriesById");

            var path = $"/Search/v3/Categories/{categoryId}";
            RestResponse response = await MakeGetRequest(path);

            int statusCode = (int)response.StatusCode;

            if (ApiClient.ExceptionFactory != null)
            {
                Exception exception = ApiClient.ExceptionFactory("CategoriesById", response);
                if (exception != null && !(statusCode == 429 && !ApiClient.Instance.ThrowRateLimitExceptions)) throw exception;
            }

            return new ApiResponse<Category>(statusCode, response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
               ApiClient.Instance.Deserialize<Category>(response));
        }

        /// <summary>
        /// Calculate the DigiReel pricing for the given DigiKeyPartNumber and RequestedQuantity 
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The Digi-Key PartNumber requested for Digi-Reel price calculation. It must be a  Digi-Key part number that is for a Digi-Reel pack type.</param>
        /// <param name="requestedQuantity">The quantity of the product you are looking to create a Digi-Reel with. Must be greater  than 0.</param>
        /// <returns>DigiReelPricingDto</returns>
        public async Task<DigiReelPricingDto> DigiReelPricing(string digiKeyPartNumber, int? requestedQuantity)
        {
            ApiResponse<DigiReelPricingDto> localVarResponse = await DigiReelPricingWithHttpInfo(digiKeyPartNumber, requestedQuantity);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Calculate the DigiReel pricing for the given DigiKeyPartNumber and RequestedQuantity 
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The Digi-Key PartNumber requested for Digi-Reel price calculation. It must be a  Digi-Key part number that is for a Digi-Reel pack type.</param>
        /// <param name="requestedQuantity">The quantity of the product you are looking to create a Digi-Reel with. Must be greater  than 0.</param>
        /// <returns>ApiResponse of DigiReelPricingDto</returns>
        public async Task<ApiResponse<DigiReelPricingDto>> DigiReelPricingWithHttpInfo(string digiKeyPartNumber, int? requestedQuantity)
        {
            // verify the required parameter 'digiKeyPartNumber' is set
            if (string.IsNullOrEmpty(digiKeyPartNumber))
                throw new ApiException(400, "Missing required parameter 'digiKeyPartNumber' when calling PartSearchApi->DigiReelPricing");
            // verify the required parameter 'requestedQuantity' is set
            if (requestedQuantity == null || !requestedQuantity.HasValue)
                throw new ApiException(400, "Missing required parameter 'requestedQuantity' when calling PartSearchApi->DigiReelPricing");

            var path = $"/Search/v3/Products/{digiKeyPartNumber}/DigiReelPricing";

            var queryParams = new List<KeyValuePair<string, string>>();

            queryParams.Add(new KeyValuePair<string, string>("requestedQuantity", requestedQuantity.Value.ToString()));

            RestResponse response = await MakeGetRequest(path, queryParams: queryParams);

            int statusCode = (int)response.StatusCode;

            if (ApiClient.ExceptionFactory != null)
            {
                Exception exception = ApiClient.ExceptionFactory("DigiReelPricing", response);
                if (exception != null && !(statusCode == 429 && !ApiClient.Instance.ThrowRateLimitExceptions)) throw exception;
            }

            return new ApiResponse<DigiReelPricingDto>(statusCode, response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
               ApiClient.Instance.Deserialize<DigiReelPricingDto>(response));
        }

        /// <summary>
        /// KeywordSearch can search for any product in the Digi-Key catalog. 
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">(optional)</param>
        /// <returns>KeywordSearchResponse</returns>
        public async Task<KeywordSearchResponse> KeywordSearch(KeywordSearchRequest body = null)
        {
            ApiResponse<KeywordSearchResponse> localVarResponse = await KeywordSearchWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// KeywordSearch can search for any product in the Digi-Key catalog. 
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info.</param>
        /// <param name="xDIGIKEYClientId">The Client Id for your App.</param>
        /// <param name="includes">(optional)</param>
        /// <param name="xDIGIKEYLocaleSite">Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH.(optional)</param>
        /// <param name="xDIGIKEYLocaleLanguage">Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no.(optional)</param>
        /// <param name="xDIGIKEYLocaleCurrency">Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP.(optional)</param>
        /// <param name="xDIGIKEYCustomerId">Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them.(optional)</param>
        /// <param name="body">(optional)</param>
        /// <returns>ApiResponse of KeywordSearchResponse</returns>
        public async Task<ApiResponse<KeywordSearchResponse>> KeywordSearchWithHttpInfo(KeywordSearchRequest body = null)
        {
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PartSearchApi->KeywordSearch");

            var path = "/Search/v3/Products/Keyword";

            RestResponse response = await MakePostRequest(path, body);

            int statusCode = (int)response.StatusCode;

            if (ApiClient.ExceptionFactory != null)
            {
                Exception exception = ApiClient.ExceptionFactory("KeywordSearch", response);
                
                if (exception != null && !(statusCode == 429 && !ApiClient.Instance.ThrowRateLimitExceptions)) throw exception;
            }

            return new ApiResponse<KeywordSearchResponse>(statusCode, response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
               ApiClient.Instance.Deserialize<KeywordSearchResponse>(response));
        }

        /// <summary>
        /// Create list of ProductDetails from the matches of the requested manufacturer product name. 
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManufacturerProductDetailsRequest(optional)</param>
        /// <returns>ProductDetailsResponse</returns>
        public async Task<ProductDetailsResponse> ManufacturerProductDetails(ManufacturerProductDetailsRequest body = null)
        {
            ApiResponse<ProductDetailsResponse> localVarResponse = await ManufacturerProductDetailsWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create list of ProductDetails from the matches of the requested manufacturer product name. 
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManufacturerProductDetailsRequest(optional)</param>
        /// <returns>ApiResponse of ProductDetailsResponse</returns>
        public async Task<ApiResponse<ProductDetailsResponse>> ManufacturerProductDetailsWithHttpInfo(ManufacturerProductDetailsRequest body = null)
        {
            // verify the required parameter 'authorization' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PartSearchApi->ManufacturerProductDetails");

            var path = "/Search/v3/Products/ManufacturerProductDetails";
            RestResponse response = await MakePostRequest(path, body);

            int statusCode = (int)response.StatusCode;

            if (ApiClient.ExceptionFactory != null)
            {
                Exception exception = ApiClient.ExceptionFactory("ManufacturerProductDetails", response);
                if (exception != null && !(statusCode == 429 && !ApiClient.Instance.ThrowRateLimitExceptions)) throw exception;
            }

            return new ApiResponse<ProductDetailsResponse>(statusCode, response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
               ApiClient.Instance.Deserialize<ProductDetailsResponse>(response));
        }

        /// <summary>
        /// Returns all Product Manufacturers. ManufacturersId can be used in KeywordSearchRequest.Filters.ManufacturerIds to restrict a keyword search to a given Manufacturer 
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ManufacturersResponse</returns>
        public async Task<ManufacturersResponse> Manufacturers()
        {
            ApiResponse<ManufacturersResponse> localVarResponse = await ManufacturersWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns all Product Manufacturers. ManufacturersId can be used in KeywordSearchRequest.Filters.ManufacturerIds to restrict a keyword search to a given Manufacturer 
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ManufacturersResponse</returns>
        public async Task<ApiResponse<ManufacturersResponse>> ManufacturersWithHttpInfo()
        {
            var path = "/Search/v3/Manufacturers";
            RestResponse response = await MakeGetRequest(path);

            int statusCode = (int)response.StatusCode;

            if (ApiClient.ExceptionFactory != null)
            {
                Exception exception = ApiClient.ExceptionFactory("Manufacturers", response);
                if (exception != null && !(statusCode == 429 && !ApiClient.Instance.ThrowRateLimitExceptions)) throw exception;
            }

            return new ApiResponse<ManufacturersResponse>(statusCode, response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
               ApiClient.Instance.Deserialize<ManufacturersResponse>(response));
        }

        /// <summary>
        /// Retrieve detailed product information including real time pricing and availability. Works best with a Digi-Key part number. Some manufacturer part numbers conflict with unrelated parts and may not  return the correct product.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States.
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The product to retrieve details for.</param>
        /// <returns>ProductDetails</returns>
        public async Task<ProductDetails> ProductDetails(string digiKeyPartNumber)
        {
            ApiResponse<ProductDetails> localVarResponse = await ProductDetailsWithHttpInfo(digiKeyPartNumber);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve detailed product information including real time pricing and availability. Works best with a Digi-Key part number. Some manufacturer part numbers conflict with unrelated parts and may not  return the correct product.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States.
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The product to retrieve details for.</param>
        /// <returns>ApiResponse of ProductDetails</returns>
        public async Task<ApiResponse<ProductDetails>> ProductDetailsWithHttpInfo(string digiKeyPartNumber)
        {
            // verify the required parameter 'digiKeyPartNumber' is set
            if (digiKeyPartNumber == null)
                throw new ApiException(400, "Missing required parameter 'digiKeyPartNumber' when calling PartSearchApi->ProductDetails");

            var path = $"/Search/v3/Products/{digiKeyPartNumber}";
            RestResponse response = await MakeGetRequest(path);

            int statusCode = (int)response.StatusCode;

            if (ApiClient.ExceptionFactory != null)
            {
                Exception exception = ApiClient.ExceptionFactory("ProductDetails", response);
                if (exception != null && !(statusCode == 429 && !ApiClient.Instance.ThrowRateLimitExceptions)) throw exception;
            }

            return new ApiResponse<ProductDetails>(statusCode, response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
               ApiClient.Instance.Deserialize<ProductDetails>(response));
        }

        /// <summary>
        /// Retrieve detailed product information and two suggested products Works best with a Digi-Key part number. Some manufacturer part numbers conflict with unrelated parts and may not  return the correct product.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States.
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partNumber">The product to retrieve details for.</param>
        /// <returns>ProductWithSuggestions</returns>
        public async Task<ProductWithSuggestions> SuggestedParts(string partNumber)
        {
            ApiResponse<ProductWithSuggestions> localVarResponse = await SuggestedPartsWithHttpInfo(partNumber);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve detailed product information and two suggested products Works best with a Digi-Key part number. Some manufacturer part numbers conflict with unrelated parts and may not  return the correct product.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States.
        /// </summary>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partNumber">The product to retrieve details for.</param>
        /// <returns>ApiResponse of ProductWithSuggestions</returns>
        public async Task<ApiResponse<ProductWithSuggestions>> SuggestedPartsWithHttpInfo(string partNumber)
        {
            // verify the required parameter 'partNumber' is set
            if (partNumber == null)
                throw new ApiException(400, "Missing required parameter 'partNumber' when calling PartSearchApi->SuggestedParts");

            var path = $"/Search/v3/Products/{partNumber}/WithSuggestedProducts";
            RestResponse response = await MakeGetRequest(path);

            int statusCode = (int)response.StatusCode;

            if (ApiClient.ExceptionFactory != null)
            {
                Exception exception = ApiClient.ExceptionFactory("SuggestedParts", response);
                if (exception != null && !(statusCode == 429 && !ApiClient.Instance.ThrowRateLimitExceptions)) throw exception;
            }

            return new ApiResponse<ProductWithSuggestions>(statusCode, response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
               ApiClient.Instance.Deserialize<ProductWithSuggestions>(response));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPartSearchApi
    {
        /// <summary>
        /// Returns all Product Categories. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CategoriesResponse</returns>
        Task<CategoriesResponse> Categories();

        /// <summary>
        /// Returns all Product Categories. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CategoriesResponse</returns>
        Task<ApiResponse<CategoriesResponse>> CategoriesWithHttpInfo();
        /// <summary>
        /// Returns Category for given Id. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId"></param>
        /// <returns>Category</returns>
        Task<Category> CategoriesById(int? categoryId);

        /// <summary>
        /// Returns Category for given Id. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId"></param>
        /// <returns>ApiResponse of Category</returns>
        Task<ApiResponse<Category>> CategoriesByIdWithHttpInfo(int? categoryId);
        /// <summary>
        /// Calculate the DigiReel pricing for the given DigiKeyPartNumber and RequestedQuantity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The Digi-Key PartNumber requested for Digi-Reel price calculation. It must be a  Digi-Key part number that is for a Digi-Reel pack type.</param>
        /// <param name="requestedQuantity">The quantity of the product you are looking to create a Digi-Reel with. Must be greater  than 0.</param>
        /// <returns>DigiReelPricingDto</returns>
        Task<DigiReelPricingDto> DigiReelPricing(string digiKeyPartNumber, int? requestedQuantity);

        /// <summary>
        /// Calculate the DigiReel pricing for the given DigiKeyPartNumber and RequestedQuantity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The Digi-Key PartNumber requested for Digi-Reel price calculation. It must be a  Digi-Key part number that is for a Digi-Reel pack type.</param>
        /// <param name="requestedQuantity">The quantity of the product you are looking to create a Digi-Reel with. Must be greater  than 0.</param>
        /// <returns>ApiResponse of DigiReelPricingDto</returns>
        Task<ApiResponse<DigiReelPricingDto>> DigiReelPricingWithHttpInfo(string digiKeyPartNumber, int? requestedQuantity);
        /// <summary>
        /// KeywordSearch can search for any product in the Digi-Key catalog.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">(optional)</param>
        /// <returns>KeywordSearchResponse</returns>
        Task<KeywordSearchResponse> KeywordSearch(KeywordSearchRequest body = null);

        /// <summary>
        /// KeywordSearch can search for any product in the Digi-Key catalog.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">(optional)</param>
        /// <returns>ApiResponse of KeywordSearchResponse</returns>
        Task<ApiResponse<KeywordSearchResponse>> KeywordSearchWithHttpInfo(KeywordSearchRequest body = null);
        /// <summary>
        /// Create list of ProductDetails from the matches of the requested manufacturer product name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManufacturerProductDetailsRequest(optional)</param>
        /// <returns>ProductDetailsResponse</returns>
        Task<ProductDetailsResponse> ManufacturerProductDetails(ManufacturerProductDetailsRequest body = null);

        /// <summary>
        /// Create list of ProductDetails from the matches of the requested manufacturer product name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManufacturerProductDetailsRequest(optional)</param>
        /// <returns>ApiResponse of ProductDetailsResponse</returns>
        Task<ApiResponse<ProductDetailsResponse>> ManufacturerProductDetailsWithHttpInfo(ManufacturerProductDetailsRequest body = null);
        /// <summary>
        /// Returns all Product Manufacturers. ManufacturersId can be used in KeywordSearchRequest.Filters.ManufacturerIds to restrict a keyword search to a given Manufacturer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ManufacturersResponse</returns>
        Task<ManufacturersResponse> Manufacturers();

        /// <summary>
        /// Returns all Product Manufacturers. ManufacturersId can be used in KeywordSearchRequest.Filters.ManufacturerIds to restrict a keyword search to a given Manufacturer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ManufacturersResponse</returns>
        Task<ApiResponse<ManufacturersResponse>> ManufacturersWithHttpInfo();
        /// <summary>
        /// Retrieve detailed product information including real time pricing and availability.
        /// </summary>
        /// <remarks>
        /// Works best with a Digi-Key part number. Some manufacturer part numbers conflict with unrelated parts and may not  return the correct product.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States.
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The product to retrieve details for.</param>
        /// <returns>ProductDetails</returns>
        Task<ProductDetails> ProductDetails(string digiKeyPartNumber);

        /// <summary>
        /// Retrieve detailed product information including real time pricing and availability.
        /// </summary>
        /// <remarks>
        /// Works best with a Digi-Key part number. Some manufacturer part numbers conflict with unrelated parts and may not  return the correct product.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States.
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The product to retrieve details for.</param>
        /// <returns>ApiResponse of ProductDetails</returns>
        Task<ApiResponse<ProductDetails>> ProductDetailsWithHttpInfo(string digiKeyPartNumber);
        /// <summary>
        /// Retrieve detailed product information and two suggested products
        /// </summary>
        /// <remarks>
        /// Works best with a Digi-Key part number. Some manufacturer part numbers conflict with unrelated parts and may not  return the correct product.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States.
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partNumber">The product to retrieve details for.</param>
        /// <returns>ProductWithSuggestions</returns>
        Task<ProductWithSuggestions> SuggestedParts(string partNumber);

        /// <summary>
        /// Retrieve detailed product information and two suggested products
        /// </summary>
        /// <remarks>
        /// Works best with a Digi-Key part number. Some manufacturer part numbers conflict with unrelated parts and may not  return the correct product.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States.
        /// </remarks>
        /// <exception cref="DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partNumber">The product to retrieve details for.</param>
        /// <returns>ApiResponse of ProductWithSuggestions</returns>
        Task<ApiResponse<ProductWithSuggestions>> SuggestedPartsWithHttpInfo(string partNumber);
    }
}
