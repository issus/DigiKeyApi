# IO.Swagger.Api.PartSearchApi

All URIs are relative to *https://api.digikey.com/Search/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Categories**](PartSearchApi.md#categories) | **GET** /Categories | Returns all Product Categories. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category
[**CategoriesById**](PartSearchApi.md#categoriesbyid) | **GET** /Categories/{categoryId} | Returns Category for given Id. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category
[**DigiReelPricing**](PartSearchApi.md#digireelpricing) | **GET** /Products/{digiKeyPartNumber}/DigiReelPricing | Calculate the DigiReel pricing for the given DigiKeyPartNumber and RequestedQuantity
[**KeywordSearch**](PartSearchApi.md#keywordsearch) | **POST** /Products/Keyword | KeywordSearch can search for any product in the Digi-Key catalog.
[**ManufacturerProductDetails**](PartSearchApi.md#manufacturerproductdetails) | **POST** /Products/ManufacturerProductDetails | Create list of ProductDetails from the matches of the requested manufacturer product name.
[**Manufacturers**](PartSearchApi.md#manufacturers) | **GET** /Manufacturers | Returns all Product Manufacturers. ManufacturersId can be used in KeywordSearchRequest.Filters.ManufacturerIds to restrict a keyword search to a given Manufacturer
[**ProductDetails**](PartSearchApi.md#productdetails) | **GET** /Products/{digiKeyPartNumber} | Retrieve detailed product information including real time pricing and availability.
[**SuggestedParts**](PartSearchApi.md#suggestedparts) | **GET** /Products/{partNumber}/WithSuggestedProducts | Retrieve detailed product information and two suggested products


<a name="categories"></a>
# **Categories**
> CategoriesResponse Categories (string authorization, string xDIGIKEYClientId, string xDIGIKEYLocaleSite = null, string xDIGIKEYLocaleLanguage = null, string xDIGIKEYLocaleCurrency = null, string xDIGIKEYCustomerId = null)

Returns all Product Categories. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoriesExample
    {
        public void main()
        {
            // Configure API key authorization: apiKeySecurity
            Configuration.Default.AddApiKey("X-DIGIKEY-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-DIGIKEY-Client-Id", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2AccessCodeSecurity
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartSearchApi();
            var authorization = authorization_example;  // string | OAuth Bearer Token. Please see<a href= \"https://developer.digikey.com/documentation/oauth\" target= \"_blank\" > OAuth 2.0 Documentation </a > page for more info.
            var xDIGIKEYClientId = xDIGIKEYClientId_example;  // string | The Client Id for your App.
            var xDIGIKEYLocaleSite = xDIGIKEYLocaleSite_example;  // string | Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. (optional) 
            var xDIGIKEYLocaleLanguage = xDIGIKEYLocaleLanguage_example;  // string | Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. (optional) 
            var xDIGIKEYLocaleCurrency = xDIGIKEYLocaleCurrency_example;  // string | Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. (optional) 
            var xDIGIKEYCustomerId = xDIGIKEYCustomerId_example;  // string | Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. (optional) 

            try
            {
                // Returns all Product Categories. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category
                CategoriesResponse result = apiInstance.Categories(authorization, xDIGIKEYClientId, xDIGIKEYLocaleSite, xDIGIKEYLocaleLanguage, xDIGIKEYLocaleCurrency, xDIGIKEYCustomerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartSearchApi.Categories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info. | 
 **xDIGIKEYClientId** | **string**| The Client Id for your App. | 
 **xDIGIKEYLocaleSite** | **string**| Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. | [optional] 
 **xDIGIKEYLocaleLanguage** | **string**| Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. | [optional] 
 **xDIGIKEYLocaleCurrency** | **string**| Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. | [optional] 
 **xDIGIKEYCustomerId** | **string**| Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. | [optional] 

### Return type

[**CategoriesResponse**](CategoriesResponse.md)

### Authorization

[apiKeySecurity](../README.md#apiKeySecurity), [oauth2AccessCodeSecurity](../README.md#oauth2AccessCodeSecurity)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categoriesbyid"></a>
# **CategoriesById**
> Category CategoriesById (int? categoryId, string authorization, string xDIGIKEYClientId, string xDIGIKEYLocaleSite = null, string xDIGIKEYLocaleLanguage = null, string xDIGIKEYLocaleCurrency = null, string xDIGIKEYCustomerId = null)

Returns Category for given Id. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoriesByIdExample
    {
        public void main()
        {
            // Configure API key authorization: apiKeySecurity
            Configuration.Default.AddApiKey("X-DIGIKEY-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-DIGIKEY-Client-Id", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2AccessCodeSecurity
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartSearchApi();
            var categoryId = 56;  // int? | 
            var authorization = authorization_example;  // string | OAuth Bearer Token. Please see<a href= \"https://developer.digikey.com/documentation/oauth\" target= \"_blank\" > OAuth 2.0 Documentation </a > page for more info.
            var xDIGIKEYClientId = xDIGIKEYClientId_example;  // string | The Client Id for your App.
            var xDIGIKEYLocaleSite = xDIGIKEYLocaleSite_example;  // string | Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. (optional) 
            var xDIGIKEYLocaleLanguage = xDIGIKEYLocaleLanguage_example;  // string | Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. (optional) 
            var xDIGIKEYLocaleCurrency = xDIGIKEYLocaleCurrency_example;  // string | Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. (optional) 
            var xDIGIKEYCustomerId = xDIGIKEYCustomerId_example;  // string | Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. (optional) 

            try
            {
                // Returns Category for given Id. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category
                Category result = apiInstance.CategoriesById(categoryId, authorization, xDIGIKEYClientId, xDIGIKEYLocaleSite, xDIGIKEYLocaleLanguage, xDIGIKEYLocaleCurrency, xDIGIKEYCustomerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartSearchApi.CategoriesById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryId** | **int?**|  | 
 **authorization** | **string**| OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info. | 
 **xDIGIKEYClientId** | **string**| The Client Id for your App. | 
 **xDIGIKEYLocaleSite** | **string**| Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. | [optional] 
 **xDIGIKEYLocaleLanguage** | **string**| Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. | [optional] 
 **xDIGIKEYLocaleCurrency** | **string**| Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. | [optional] 
 **xDIGIKEYCustomerId** | **string**| Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. | [optional] 

### Return type

[**Category**](Category.md)

### Authorization

[apiKeySecurity](../README.md#apiKeySecurity), [oauth2AccessCodeSecurity](../README.md#oauth2AccessCodeSecurity)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="digireelpricing"></a>
# **DigiReelPricing**
> DigiReelPricingDto DigiReelPricing (string digiKeyPartNumber, int? requestedQuantity, string authorization, string xDIGIKEYClientId, string includes = null, string xDIGIKEYLocaleSite = null, string xDIGIKEYLocaleLanguage = null, string xDIGIKEYLocaleCurrency = null, string xDIGIKEYCustomerId = null)

Calculate the DigiReel pricing for the given DigiKeyPartNumber and RequestedQuantity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DigiReelPricingExample
    {
        public void main()
        {
            // Configure API key authorization: apiKeySecurity
            Configuration.Default.AddApiKey("X-DIGIKEY-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-DIGIKEY-Client-Id", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2AccessCodeSecurity
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartSearchApi();
            var digiKeyPartNumber = digiKeyPartNumber_example;  // string | The Digi-Key PartNumber requested for Digi-Reel price calculation. It must be a  Digi-Key part number that is for a Digi-Reel pack type.
            var requestedQuantity = 56;  // int? | The quantity of the product you are looking to create a Digi-Reel with. Must be greater  than 0.
            var authorization = authorization_example;  // string | OAuth Bearer Token. Please see<a href= \"https://developer.digikey.com/documentation/oauth\" target= \"_blank\" > OAuth 2.0 Documentation </a > page for more info.
            var xDIGIKEYClientId = xDIGIKEYClientId_example;  // string | The Client Id for your App.
            var includes = includes_example;  // string | Comma separated list of fields to return. Used to customize response to reduce bandwidth by  selecting fields that you wish to receive. For example: \"ExtendedPrice,ReelingFee\" (optional) 
            var xDIGIKEYLocaleSite = xDIGIKEYLocaleSite_example;  // string | Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. (optional) 
            var xDIGIKEYLocaleLanguage = xDIGIKEYLocaleLanguage_example;  // string | Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. (optional) 
            var xDIGIKEYLocaleCurrency = xDIGIKEYLocaleCurrency_example;  // string | Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. (optional) 
            var xDIGIKEYCustomerId = xDIGIKEYCustomerId_example;  // string | Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. (optional) 

            try
            {
                // Calculate the DigiReel pricing for the given DigiKeyPartNumber and RequestedQuantity
                DigiReelPricingDto result = apiInstance.DigiReelPricing(digiKeyPartNumber, requestedQuantity, authorization, xDIGIKEYClientId, includes, xDIGIKEYLocaleSite, xDIGIKEYLocaleLanguage, xDIGIKEYLocaleCurrency, xDIGIKEYCustomerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartSearchApi.DigiReelPricing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **digiKeyPartNumber** | **string**| The Digi-Key PartNumber requested for Digi-Reel price calculation. It must be a  Digi-Key part number that is for a Digi-Reel pack type. | 
 **requestedQuantity** | **int?**| The quantity of the product you are looking to create a Digi-Reel with. Must be greater  than 0. | 
 **authorization** | **string**| OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info. | 
 **xDIGIKEYClientId** | **string**| The Client Id for your App. | 
 **includes** | **string**| Comma separated list of fields to return. Used to customize response to reduce bandwidth by  selecting fields that you wish to receive. For example: \&quot;ExtendedPrice,ReelingFee\&quot; | [optional] 
 **xDIGIKEYLocaleSite** | **string**| Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. | [optional] 
 **xDIGIKEYLocaleLanguage** | **string**| Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. | [optional] 
 **xDIGIKEYLocaleCurrency** | **string**| Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. | [optional] 
 **xDIGIKEYCustomerId** | **string**| Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. | [optional] 

### Return type

[**DigiReelPricingDto**](DigiReelPricingDto.md)

### Authorization

[apiKeySecurity](../README.md#apiKeySecurity), [oauth2AccessCodeSecurity](../README.md#oauth2AccessCodeSecurity)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keywordsearch"></a>
# **KeywordSearch**
> KeywordSearchResponse KeywordSearch (string authorization, string xDIGIKEYClientId, string includes = null, string xDIGIKEYLocaleSite = null, string xDIGIKEYLocaleLanguage = null, string xDIGIKEYLocaleCurrency = null, string xDIGIKEYCustomerId = null, KeywordSearchRequest body = null)

KeywordSearch can search for any product in the Digi-Key catalog.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class KeywordSearchExample
    {
        public void main()
        {
            // Configure API key authorization: apiKeySecurity
            Configuration.Default.AddApiKey("X-DIGIKEY-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-DIGIKEY-Client-Id", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2AccessCodeSecurity
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartSearchApi();
            var authorization = authorization_example;  // string | OAuth Bearer Token. Please see<a href= \"https://developer.digikey.com/documentation/oauth\" target= \"_blank\" > OAuth 2.0 Documentation </a > page for more info.
            var xDIGIKEYClientId = xDIGIKEYClientId_example;  // string | The Client Id for your App.
            var includes = includes_example;  // string |  (optional) 
            var xDIGIKEYLocaleSite = xDIGIKEYLocaleSite_example;  // string | Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. (optional) 
            var xDIGIKEYLocaleLanguage = xDIGIKEYLocaleLanguage_example;  // string | Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. (optional) 
            var xDIGIKEYLocaleCurrency = xDIGIKEYLocaleCurrency_example;  // string | Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. (optional) 
            var xDIGIKEYCustomerId = xDIGIKEYCustomerId_example;  // string | Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. (optional) 
            var body = new KeywordSearchRequest(); // KeywordSearchRequest |  (optional) 

            try
            {
                // KeywordSearch can search for any product in the Digi-Key catalog.
                KeywordSearchResponse result = apiInstance.KeywordSearch(authorization, xDIGIKEYClientId, includes, xDIGIKEYLocaleSite, xDIGIKEYLocaleLanguage, xDIGIKEYLocaleCurrency, xDIGIKEYCustomerId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartSearchApi.KeywordSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info. | 
 **xDIGIKEYClientId** | **string**| The Client Id for your App. | 
 **includes** | **string**|  | [optional] 
 **xDIGIKEYLocaleSite** | **string**| Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. | [optional] 
 **xDIGIKEYLocaleLanguage** | **string**| Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. | [optional] 
 **xDIGIKEYLocaleCurrency** | **string**| Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. | [optional] 
 **xDIGIKEYCustomerId** | **string**| Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. | [optional] 
 **body** | [**KeywordSearchRequest**](KeywordSearchRequest.md)|  | [optional] 

### Return type

[**KeywordSearchResponse**](KeywordSearchResponse.md)

### Authorization

[apiKeySecurity](../README.md#apiKeySecurity), [oauth2AccessCodeSecurity](../README.md#oauth2AccessCodeSecurity)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="manufacturerproductdetails"></a>
# **ManufacturerProductDetails**
> ProductDetailsResponse ManufacturerProductDetails (string authorization, string xDIGIKEYClientId, string includes = null, string xDIGIKEYLocaleSite = null, string xDIGIKEYLocaleLanguage = null, string xDIGIKEYLocaleCurrency = null, string xDIGIKEYCustomerId = null, ManufacturerProductDetailsRequest body = null)

Create list of ProductDetails from the matches of the requested manufacturer product name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ManufacturerProductDetailsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKeySecurity
            Configuration.Default.AddApiKey("X-DIGIKEY-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-DIGIKEY-Client-Id", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2AccessCodeSecurity
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartSearchApi();
            var authorization = authorization_example;  // string | OAuth Bearer Token. Please see<a href= \"https://developer.digikey.com/documentation/oauth\" target= \"_blank\" > OAuth 2.0 Documentation </a > page for more info.
            var xDIGIKEYClientId = xDIGIKEYClientId_example;  // string | The Client Id for your App.
            var includes = includes_example;  // string | Comma separated list of fields to return. Used to customize response to reduce bandwidth by  selecting fields that you wish to receive. For example: \"Products(DigiKeyPartNumber,QuantityAvailable)\" (optional) 
            var xDIGIKEYLocaleSite = xDIGIKEYLocaleSite_example;  // string | Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. (optional) 
            var xDIGIKEYLocaleLanguage = xDIGIKEYLocaleLanguage_example;  // string | Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. (optional) 
            var xDIGIKEYLocaleCurrency = xDIGIKEYLocaleCurrency_example;  // string | Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. (optional) 
            var xDIGIKEYCustomerId = xDIGIKEYCustomerId_example;  // string | Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. (optional) 
            var body = new ManufacturerProductDetailsRequest(); // ManufacturerProductDetailsRequest | ManufacturerProductDetailsRequest (optional) 

            try
            {
                // Create list of ProductDetails from the matches of the requested manufacturer product name.
                ProductDetailsResponse result = apiInstance.ManufacturerProductDetails(authorization, xDIGIKEYClientId, includes, xDIGIKEYLocaleSite, xDIGIKEYLocaleLanguage, xDIGIKEYLocaleCurrency, xDIGIKEYCustomerId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartSearchApi.ManufacturerProductDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info. | 
 **xDIGIKEYClientId** | **string**| The Client Id for your App. | 
 **includes** | **string**| Comma separated list of fields to return. Used to customize response to reduce bandwidth by  selecting fields that you wish to receive. For example: \&quot;Products(DigiKeyPartNumber,QuantityAvailable)\&quot; | [optional] 
 **xDIGIKEYLocaleSite** | **string**| Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. | [optional] 
 **xDIGIKEYLocaleLanguage** | **string**| Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. | [optional] 
 **xDIGIKEYLocaleCurrency** | **string**| Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. | [optional] 
 **xDIGIKEYCustomerId** | **string**| Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. | [optional] 
 **body** | [**ManufacturerProductDetailsRequest**](ManufacturerProductDetailsRequest.md)| ManufacturerProductDetailsRequest | [optional] 

### Return type

[**ProductDetailsResponse**](ProductDetailsResponse.md)

### Authorization

[apiKeySecurity](../README.md#apiKeySecurity), [oauth2AccessCodeSecurity](../README.md#oauth2AccessCodeSecurity)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="manufacturers"></a>
# **Manufacturers**
> ManufacturersResponse Manufacturers (string authorization, string xDIGIKEYClientId, string xDIGIKEYLocaleSite = null, string xDIGIKEYLocaleLanguage = null, string xDIGIKEYLocaleCurrency = null, string xDIGIKEYCustomerId = null)

Returns all Product Manufacturers. ManufacturersId can be used in KeywordSearchRequest.Filters.ManufacturerIds to restrict a keyword search to a given Manufacturer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ManufacturersExample
    {
        public void main()
        {
            // Configure API key authorization: apiKeySecurity
            Configuration.Default.AddApiKey("X-DIGIKEY-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-DIGIKEY-Client-Id", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2AccessCodeSecurity
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartSearchApi();
            var authorization = authorization_example;  // string | OAuth Bearer Token. Please see<a href= \"https://developer.digikey.com/documentation/oauth\" target= \"_blank\" > OAuth 2.0 Documentation </a > page for more info.
            var xDIGIKEYClientId = xDIGIKEYClientId_example;  // string | The Client Id for your App.
            var xDIGIKEYLocaleSite = xDIGIKEYLocaleSite_example;  // string | Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. (optional) 
            var xDIGIKEYLocaleLanguage = xDIGIKEYLocaleLanguage_example;  // string | Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. (optional) 
            var xDIGIKEYLocaleCurrency = xDIGIKEYLocaleCurrency_example;  // string | Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. (optional) 
            var xDIGIKEYCustomerId = xDIGIKEYCustomerId_example;  // string | Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. (optional) 

            try
            {
                // Returns all Product Manufacturers. ManufacturersId can be used in KeywordSearchRequest.Filters.ManufacturerIds to restrict a keyword search to a given Manufacturer
                ManufacturersResponse result = apiInstance.Manufacturers(authorization, xDIGIKEYClientId, xDIGIKEYLocaleSite, xDIGIKEYLocaleLanguage, xDIGIKEYLocaleCurrency, xDIGIKEYCustomerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartSearchApi.Manufacturers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info. | 
 **xDIGIKEYClientId** | **string**| The Client Id for your App. | 
 **xDIGIKEYLocaleSite** | **string**| Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. | [optional] 
 **xDIGIKEYLocaleLanguage** | **string**| Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. | [optional] 
 **xDIGIKEYLocaleCurrency** | **string**| Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. | [optional] 
 **xDIGIKEYCustomerId** | **string**| Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. | [optional] 

### Return type

[**ManufacturersResponse**](ManufacturersResponse.md)

### Authorization

[apiKeySecurity](../README.md#apiKeySecurity), [oauth2AccessCodeSecurity](../README.md#oauth2AccessCodeSecurity)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productdetails"></a>
# **ProductDetails**
> ProductDetails ProductDetails (string digiKeyPartNumber, string authorization, string xDIGIKEYClientId, string includes = null, string xDIGIKEYLocaleSite = null, string xDIGIKEYLocaleLanguage = null, string xDIGIKEYLocaleCurrency = null, string xDIGIKEYCustomerId = null)

Retrieve detailed product information including real time pricing and availability.

Works best with a Digi-Key part number. Some manufacturer part numbers conflict with unrelated parts and may not  return the correct product.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductDetailsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKeySecurity
            Configuration.Default.AddApiKey("X-DIGIKEY-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-DIGIKEY-Client-Id", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2AccessCodeSecurity
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartSearchApi();
            var digiKeyPartNumber = digiKeyPartNumber_example;  // string | The product to retrieve details for.
            var authorization = authorization_example;  // string | OAuth Bearer Token. Please see<a href= \"https://developer.digikey.com/documentation/oauth\" target= \"_blank\" > OAuth 2.0 Documentation </a > page for more info.
            var xDIGIKEYClientId = xDIGIKEYClientId_example;  // string | The Client Id for your App.
            var includes = includes_example;  // string | Comma separated list of fields to return. Used to customize response to reduce bandwidth by  selecting fields that you wish to receive. For example: \"DigiKeyPartNumber,QuantityAvailable,AssociatedProducts[2]\" (optional) 
            var xDIGIKEYLocaleSite = xDIGIKEYLocaleSite_example;  // string | Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. (optional) 
            var xDIGIKEYLocaleLanguage = xDIGIKEYLocaleLanguage_example;  // string | Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. (optional) 
            var xDIGIKEYLocaleCurrency = xDIGIKEYLocaleCurrency_example;  // string | Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. (optional) 
            var xDIGIKEYCustomerId = xDIGIKEYCustomerId_example;  // string | Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. (optional) 

            try
            {
                // Retrieve detailed product information including real time pricing and availability.
                ProductDetails result = apiInstance.ProductDetails(digiKeyPartNumber, authorization, xDIGIKEYClientId, includes, xDIGIKEYLocaleSite, xDIGIKEYLocaleLanguage, xDIGIKEYLocaleCurrency, xDIGIKEYCustomerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartSearchApi.ProductDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **digiKeyPartNumber** | **string**| The product to retrieve details for. | 
 **authorization** | **string**| OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info. | 
 **xDIGIKEYClientId** | **string**| The Client Id for your App. | 
 **includes** | **string**| Comma separated list of fields to return. Used to customize response to reduce bandwidth by  selecting fields that you wish to receive. For example: \&quot;DigiKeyPartNumber,QuantityAvailable,AssociatedProducts[2]\&quot; | [optional] 
 **xDIGIKEYLocaleSite** | **string**| Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. | [optional] 
 **xDIGIKEYLocaleLanguage** | **string**| Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. | [optional] 
 **xDIGIKEYLocaleCurrency** | **string**| Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. | [optional] 
 **xDIGIKEYCustomerId** | **string**| Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. | [optional] 

### Return type

[**ProductDetails**](ProductDetails.md)

### Authorization

[apiKeySecurity](../README.md#apiKeySecurity), [oauth2AccessCodeSecurity](../README.md#oauth2AccessCodeSecurity)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suggestedparts"></a>
# **SuggestedParts**
> ProductWithSuggestions SuggestedParts (string partNumber, string authorization, string xDIGIKEYClientId, string xDIGIKEYLocaleSite = null, string xDIGIKEYLocaleLanguage = null, string xDIGIKEYLocaleCurrency = null, string xDIGIKEYCustomerId = null)

Retrieve detailed product information and two suggested products

Works best with a Digi-Key part number. Some manufacturer part numbers conflict with unrelated parts and may not  return the correct product.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SuggestedPartsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKeySecurity
            Configuration.Default.AddApiKey("X-DIGIKEY-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-DIGIKEY-Client-Id", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2AccessCodeSecurity
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartSearchApi();
            var partNumber = partNumber_example;  // string | The product to retrieve details for.
            var authorization = authorization_example;  // string | OAuth Bearer Token. Please see<a href= \"https://developer.digikey.com/documentation/oauth\" target= \"_blank\" > OAuth 2.0 Documentation </a > page for more info.
            var xDIGIKEYClientId = xDIGIKEYClientId_example;  // string | The Client Id for your App.
            var xDIGIKEYLocaleSite = xDIGIKEYLocaleSite_example;  // string | Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. (optional) 
            var xDIGIKEYLocaleLanguage = xDIGIKEYLocaleLanguage_example;  // string | Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. (optional) 
            var xDIGIKEYLocaleCurrency = xDIGIKEYLocaleCurrency_example;  // string | Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. (optional) 
            var xDIGIKEYCustomerId = xDIGIKEYCustomerId_example;  // string | Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. (optional) 

            try
            {
                // Retrieve detailed product information and two suggested products
                ProductWithSuggestions result = apiInstance.SuggestedParts(partNumber, authorization, xDIGIKEYClientId, xDIGIKEYLocaleSite, xDIGIKEYLocaleLanguage, xDIGIKEYLocaleCurrency, xDIGIKEYCustomerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartSearchApi.SuggestedParts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **partNumber** | **string**| The product to retrieve details for. | 
 **authorization** | **string**| OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info. | 
 **xDIGIKEYClientId** | **string**| The Client Id for your App. | 
 **xDIGIKEYLocaleSite** | **string**| Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. | [optional] 
 **xDIGIKEYLocaleLanguage** | **string**| Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. | [optional] 
 **xDIGIKEYLocaleCurrency** | **string**| Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. | [optional] 
 **xDIGIKEYCustomerId** | **string**| Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. | [optional] 

### Return type

[**ProductWithSuggestions**](ProductWithSuggestions.md)

### Authorization

[apiKeySecurity](../README.md#apiKeySecurity), [oauth2AccessCodeSecurity](../README.md#oauth2AccessCodeSecurity)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

