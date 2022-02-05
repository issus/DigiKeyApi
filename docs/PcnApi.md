# DigiKey.Api.Api.PcnApi

All URIs are relative to *https://api.digikey.com/ChangeNotifications/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProductChangeNotifications**](PcnApi.md#productchangenotifications) | **GET** /Products/{DigiKeyPartNumber} | This returns all change notifications for the given DigiKey product.


<a name="productchangenotifications"></a>
# **ProductChangeNotifications**
> PcnResponse ProductChangeNotifications (string digiKeyPartNumber, string authorization, string xDIGIKEYClientId, string includes = null, string xDIGIKEYLocaleSite = null, string xDIGIKEYLocaleLanguage = null, string xDIGIKEYLocaleCurrency = null, string xDIGIKEYLocaleShipToCountry = null)

This returns all change notifications for the given DigiKey product.

### Example
```csharp
using System;
using System.Diagnostics;
using DigiKey.Api.Api;
using DigiKey.Api.Client;
using DigiKey.Api.Model;

namespace Example
{
    public class ProductChangeNotificationsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKeySecurity
            Configuration.Default.AddApiKey("X-DIGIKEY-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-DIGIKEY-Client-Id", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2AccessCodeSecurity
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PcnApi();
            var digiKeyPartNumber = digiKeyPartNumber_example;  // string | The product to retrieve change notifications for.
            var authorization = authorization_example;  // string | OAuth Bearer Token. Please see<a href= \"https://developer.digikey.com/documentation/oauth\" target= \"_blank\" > OAuth 2.0 Documentation </a > page for more info.
            var xDIGIKEYClientId = xDIGIKEYClientId_example;  // string | The Client Id for your App.
            var includes = includes_example;  // string | Comma separated list of fields to return. Used to customize response to reduce bandwidth by selecting fields that you wish to receive. For example: \"ProductChangeNotifications\\[2\\](PcnType,PcnDescription)\" (optional) 
            var xDIGIKEYLocaleSite = xDIGIKEYLocaleSite_example;  // string | Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. (optional) 
            var xDIGIKEYLocaleLanguage = xDIGIKEYLocaleLanguage_example;  // string | Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. (optional) 
            var xDIGIKEYLocaleCurrency = xDIGIKEYLocaleCurrency_example;  // string | Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. (optional) 
            var xDIGIKEYLocaleShipToCountry = xDIGIKEYLocaleShipToCountry_example;  // string | ISO code for country to ship to. (optional) 

            try
            {
                // This returns all change notifications for the given DigiKey product.
                PcnResponse result = apiInstance.ProductChangeNotifications(digiKeyPartNumber, authorization, xDIGIKEYClientId, includes, xDIGIKEYLocaleSite, xDIGIKEYLocaleLanguage, xDIGIKEYLocaleCurrency, xDIGIKEYLocaleShipToCountry);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PcnApi.ProductChangeNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **digiKeyPartNumber** | **string**| The product to retrieve change notifications for. | 
 **authorization** | **string**| OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info. | 
 **xDIGIKEYClientId** | **string**| The Client Id for your App. | 
 **includes** | **string**| Comma separated list of fields to return. Used to customize response to reduce bandwidth by selecting fields that you wish to receive. For example: \&quot;ProductChangeNotifications\\[2\\](PcnType,PcnDescription)\&quot; | [optional] 
 **xDIGIKEYLocaleSite** | **string**| Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. | [optional] 
 **xDIGIKEYLocaleLanguage** | **string**| Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. | [optional] 
 **xDIGIKEYLocaleCurrency** | **string**| Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. | [optional] 
 **xDIGIKEYLocaleShipToCountry** | **string**| ISO code for country to ship to. | [optional] 

### Return type

[**PcnResponse**](PcnResponse.md)

### Authorization

[apiKeySecurity](../README.md#apiKeySecurity), [oauth2AccessCodeSecurity](../README.md#oauth2AccessCodeSecurity)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

