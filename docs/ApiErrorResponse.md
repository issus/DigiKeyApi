# IO.Swagger.Model.ApiErrorResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ErrorResponseVersion** | **string** | The version of the error handler. | [optional] 
**StatusCode** | **int?** | The HttpStatusCode of the error. | [optional] 
**ErrorMessage** | **string** | The message provided by the error handler. | [optional] 
**ErrorDetails** | **string** | The details of the error. | [optional] 
**RequestId** | **string** | The Id of the request that triggered the error. If contacting API Support, please include the RequestId. | [optional] 
**ValidationErrors** | [**List&lt;ApiValidationError&gt;**](ApiValidationError.md) | The list of validation errors (if applicable). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

