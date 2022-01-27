# IO.Swagger.Api.PackageTypeByQuantityApi

All URIs are relative to *https://api.digikey.com/PackageTypeByQuantity/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PackageTypeByQuantity**](PackageTypeByQuantityApi.md#packagetypebyquantity) | **GET** /Products/{DigiKeyPartNumber} | Provide a part number and quantity to receive product information such as pricing, available quantity, and the best  packaging type for the requested quantity of the product.  For example, given a requested quantity larger than a standard reel, this will return information about the  standard tape and reel as well as either cut tape or DKR depending on the provided preference.  Made for Cut Tape, Tape and Reel, and Digi-Reel products only. Other packaging types can be searched for, but  results may vary.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States.


<a name="packagetypebyquantity"></a>
# **PackageTypeByQuantity**
> PackageTypeByQuantityResponse PackageTypeByQuantity (string digiKeyPartNumber, int? requestedQuantity, string authorization, string xDIGIKEYClientId, string packagingPreference = null, string includes = null, string xDIGIKEYLocaleSite = null, string xDIGIKEYLocaleLanguage = null, string xDIGIKEYLocaleCurrency = null, string xDIGIKEYLocaleShipToCountry = null, string xDIGIKEYCustomerId = null)

Provide a part number and quantity to receive product information such as pricing, available quantity, and the best  packaging type for the requested quantity of the product.  For example, given a requested quantity larger than a standard reel, this will return information about the  standard tape and reel as well as either cut tape or DKR depending on the provided preference.  Made for Cut Tape, Tape and Reel, and Digi-Reel products only. Other packaging types can be searched for, but  results may vary.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PackageTypeByQuantityExample
    {
        public void main()
        {
            // Configure API key authorization: apiKeySecurity
            Configuration.Default.AddApiKey("X-DIGIKEY-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-DIGIKEY-Client-Id", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2AccessCodeSecurity
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PackageTypeByQuantityApi();
            var digiKeyPartNumber = digiKeyPartNumber_example;  // string | A part number. Can be either Digi-Key or Manufacturer, but some manufacturer part  numbers are ambiguous and will not be found. A DKR part number will override a CT packagingPreference.
            var requestedQuantity = 56;  // int? | The quantity of the product that you are interested in. This will be used to determined  the quantity to purchase in standard tape and reel, and also in your part preference for the remainder.
            var authorization = authorization_example;  // string | OAuth Bearer Token. Please see<a href= \"https://developer.digikey.com/documentation/oauth\" target= \"_blank\" > OAuth 2.0 Documentation </a > page for more info.
            var xDIGIKEYClientId = xDIGIKEYClientId_example;  // string | The Client Id for your App.
            var packagingPreference = packagingPreference_example;  // string | Can be either \"CT\" for Cut Tape or \"DKR\" for Digi-Reel. This will select what package  type to use for the remainder of quantity outside of a standard reel. (optional) 
            var includes = includes_example;  // string | Comma separated list of fields to return. Used to customize response and reduce bandwidth by  specifying fields that you wish to receive. For example: \"Products(DigiKeyPartNumber,QuantityAvailable)\" (optional) 
            var xDIGIKEYLocaleSite = xDIGIKEYLocaleSite_example;  // string | Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. (optional) 
            var xDIGIKEYLocaleLanguage = xDIGIKEYLocaleLanguage_example;  // string | Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. (optional) 
            var xDIGIKEYLocaleCurrency = xDIGIKEYLocaleCurrency_example;  // string | Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. (optional) 
            var xDIGIKEYLocaleShipToCountry = xDIGIKEYLocaleShipToCountry_example;  // string | ISO code for country to ship to. (optional) 
            var xDIGIKEYCustomerId = xDIGIKEYCustomerId_example;  // string | Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. (optional) 

            try
            {
                // Provide a part number and quantity to receive product information such as pricing, available quantity, and the best  packaging type for the requested quantity of the product.  For example, given a requested quantity larger than a standard reel, this will return information about the  standard tape and reel as well as either cut tape or DKR depending on the provided preference.  Made for Cut Tape, Tape and Reel, and Digi-Reel products only. Other packaging types can be searched for, but  results may vary.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States.
                PackageTypeByQuantityResponse result = apiInstance.PackageTypeByQuantity(digiKeyPartNumber, requestedQuantity, authorization, xDIGIKEYClientId, packagingPreference, includes, xDIGIKEYLocaleSite, xDIGIKEYLocaleLanguage, xDIGIKEYLocaleCurrency, xDIGIKEYLocaleShipToCountry, xDIGIKEYCustomerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackageTypeByQuantityApi.PackageTypeByQuantity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **digiKeyPartNumber** | **string**| A part number. Can be either Digi-Key or Manufacturer, but some manufacturer part  numbers are ambiguous and will not be found. A DKR part number will override a CT packagingPreference. | 
 **requestedQuantity** | **int?**| The quantity of the product that you are interested in. This will be used to determined  the quantity to purchase in standard tape and reel, and also in your part preference for the remainder. | 
 **authorization** | **string**| OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info. | 
 **xDIGIKEYClientId** | **string**| The Client Id for your App. | 
 **packagingPreference** | **string**| Can be either \&quot;CT\&quot; for Cut Tape or \&quot;DKR\&quot; for Digi-Reel. This will select what package  type to use for the remainder of quantity outside of a standard reel. | [optional] 
 **includes** | **string**| Comma separated list of fields to return. Used to customize response and reduce bandwidth by  specifying fields that you wish to receive. For example: \&quot;Products(DigiKeyPartNumber,QuantityAvailable)\&quot; | [optional] 
 **xDIGIKEYLocaleSite** | **string**| Two letter code for Digi-Key product website to search on. Different countries sites have different part restrictions, supported languages, and currencies. Acceptable values include: US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH. | [optional] 
 **xDIGIKEYLocaleLanguage** | **string**| Two letter code for language to search on. Langauge must be supported by the selected site. If searching on keyword, this language is used to find matches. Acceptable values include: en, ja, de, fr, ko, zhs, zht, it, es, he, nl, sv, pl, fi, da, no. | [optional] 
 **xDIGIKEYLocaleCurrency** | **string**| Three letter code for Currency to return part pricing for. Currency must be supported by the selected site. Acceptable values include: USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP. | [optional] 
 **xDIGIKEYLocaleShipToCountry** | **string**| ISO code for country to ship to. | [optional] 
 **xDIGIKEYCustomerId** | **string**| Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. | [optional] 

### Return type

[**PackageTypeByQuantityResponse**](PackageTypeByQuantityResponse.md)

### Authorization

[apiKeySecurity](../README.md#apiKeySecurity), [oauth2AccessCodeSecurity](../README.md#oauth2AccessCodeSecurity)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

