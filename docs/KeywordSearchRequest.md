# IO.Swagger.Model.KeywordSearchRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Keywords** | **string** | Keywords to search on. Can be a description, partial part number, manufacturer part number, or a Digi-Key part  number. Keywords are required unless the Filters.TaxonomyIds is populated. An Empty string can be used when searching with Filters.TaxonomyIds | [optional] 
**RecordCount** | **int?** | Number of products to return between 1 and 50. | [optional] 
**RecordStartPosition** | **int?** | The starting index of the records returned. This is used to paginate beyond 50 results. | [optional] 
**Filters** | [**Filters**](Filters.md) |  | [optional] 
**Sort** | [**SortParameters**](SortParameters.md) |  | [optional] 
**RequestedQuantity** | **int?** | The quantity of the product you are looking to purchase. This is used with the SortByUnitPrice SortOption as price  varies at differing quantities. | [optional] 
**SearchOptions** | [**List&lt;SearchOption&gt;**](SearchOption.md) | Filters the search results by the included SearchOption. | [optional] 
**ExcludeMarketPlaceProducts** | **bool?** | Used to exclude MarkPlace products from search results. Default is false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

