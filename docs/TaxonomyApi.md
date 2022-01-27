# IO.Swagger.Api.TaxonomyApi

All URIs are relative to *https://api.digikey.com/taxonomysearch/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TaxonomySearch**](TaxonomyApi.md#taxonomysearch) | **GET** /{category} | Retrieves a URL to a filtered partsearch page. Any filter names and values may be used as query parameters as long as it exists for the category. For example: \&quot;color&#x3D;black\&quot;. However, these cannot be entered on the Swagger page.


<a name="taxonomysearch"></a>
# **TaxonomySearch**
> string TaxonomySearch (string category, string authorization, string xDIGIKEYClientId)

Retrieves a URL to a filtered partsearch page. Any filter names and values may be used as query parameters as long as it exists for the category. For example: \"color=black\". However, these cannot be entered on the Swagger page.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TaxonomySearchExample
    {
        public void main()
        {
            // Configure API key authorization: apiKeySecurity
            Configuration.Default.AddApiKey("X-DIGIKEY-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-DIGIKEY-Client-Id", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2AccessCodeSecurity
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxonomyApi();
            var category = category_example;  // string | Category name to filter within. If the category has a parent it can be included as \"parent:child\". If no parent is provided, only child categories are searched. Note that some child categories exist in multiple parents.
            var authorization = authorization_example;  // string | OAuth Bearer Token. Please see<a href= \"https://developer.digikey.com/documentation/oauth\" target= \"_blank\" > OAuth 2.0 Documentation </a > page for more info.
            var xDIGIKEYClientId = xDIGIKEYClientId_example;  // string | The Client Id for your App.

            try
            {
                // Retrieves a URL to a filtered partsearch page. Any filter names and values may be used as query parameters as long as it exists for the category. For example: \"color=black\". However, these cannot be entered on the Swagger page.
                string result = apiInstance.TaxonomySearch(category, authorization, xDIGIKEYClientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxonomyApi.TaxonomySearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | **string**| Category name to filter within. If the category has a parent it can be included as \&quot;parent:child\&quot;. If no parent is provided, only child categories are searched. Note that some child categories exist in multiple parents. | 
 **authorization** | **string**| OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info. | 
 **xDIGIKEYClientId** | **string**| The Client Id for your App. | 

### Return type

**string**

### Authorization

[apiKeySecurity](../README.md#apiKeySecurity), [oauth2AccessCodeSecurity](../README.md#oauth2AccessCodeSecurity)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

