# IO.Swagger.Api.ProductTracingApi

All URIs are relative to *https://api.digikey.com/ProductTracing/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Details**](ProductTracingApi.md#details) | **GET** /Details/{tracingId} | Retrieve detailed information about the product being traced


<a name="details"></a>
# **Details**
> ProductTracingResponse Details (string tracingId, string authorization, string xDIGIKEYClientId, string xDIGIKEYCustomerId = null)

Retrieve detailed information about the product being traced

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DetailsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKeySecurity
            Configuration.Default.AddApiKey("X-DIGIKEY-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-DIGIKEY-Client-Id", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2AccessCodeSecurity
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductTracingApi();
            var tracingId = tracingId_example;  // string | The tracing Id of the product being traced
            var authorization = authorization_example;  // string | OAuth Bearer Token. Please see<a href= \"https://developer.digikey.com/documentation/oauth\" target= \"_blank\" > OAuth 2.0 Documentation </a > page for more info.
            var xDIGIKEYClientId = xDIGIKEYClientId_example;  // string | The Client Id for your App.
            var xDIGIKEYCustomerId = xDIGIKEYCustomerId_example;  // string | Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. (optional) 

            try
            {
                // Retrieve detailed information about the product being traced
                ProductTracingResponse result = apiInstance.Details(tracingId, authorization, xDIGIKEYClientId, xDIGIKEYCustomerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductTracingApi.Details: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tracingId** | **string**| The tracing Id of the product being traced | 
 **authorization** | **string**| OAuth Bearer Token. Please see&lt;a href&#x3D; \&quot;https://developer.digikey.com/documentation/oauth\&quot; target&#x3D; \&quot;_blank\&quot; &gt; OAuth 2.0 Documentation &lt;/a &gt; page for more info. | 
 **xDIGIKEYClientId** | **string**| The Client Id for your App. | 
 **xDIGIKEYCustomerId** | **string**| Your Digi-Key Customer id. If your account has multiple Customer Ids for different regions, this allows you to select one of them. | [optional] 

### Return type

[**ProductTracingResponse**](ProductTracingResponse.md)

### Authorization

[apiKeySecurity](../README.md#apiKeySecurity), [oauth2AccessCodeSecurity](../README.md#oauth2AccessCodeSecurity)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

