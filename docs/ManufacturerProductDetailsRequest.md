# IO.Swagger.Model.ManufacturerProductDetailsRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ManufacturerProduct** | **string** | Manufacturer product name to search on. | 
**RecordCount** | **int?** | Number of products to return between 1 and 50. | [optional] 
**RecordStartPosition** | **int?** | The starting index of the records returned. This is used to paginate beyond 50 results. | [optional] 
**Filters** | [**Filters**](Filters.md) |  | [optional] 
**Sort** | [**SortParameters**](SortParameters.md) |  | [optional] 
**RequestedQuantity** | **int?** | The quantity of the product you are looking to purchase. This is used with the SortByUnitPrice SortOption as price varies at differing quantities. | [optional] 
**SearchOptions** | [**List&lt;SearchOption&gt;**](SearchOption.md) | Filters the search results by the included SearchOption. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

