# DigiKey.Api.Model.KeywordSearchResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LimitedTaxonomy** | [**LimitedTaxonomy**](LimitedTaxonomy.md) |  | [optional] 
**FilterOptions** | [**List&lt;LimitedParameter&gt;**](LimitedParameter.md) | Available filters for narrowing down results. | [optional] 
**Products** | [**List&lt;Product&gt;**](Product.md) | List of products returned by KeywordSearch | [optional] 
**ProductsCount** | **int?** | Total number of matching products found. | [optional] 
**ExactManufacturerProductsCount** | **int?** | Number of exact ManufacturerPartNumber matches. | [optional] 
**ExactManufacturerProducts** | [**List&lt;Product&gt;**](Product.md) | List of products that are exact ManufacturerPartNumber matches. | [optional] 
**ExactDigiKeyProduct** | [**Product**](Product.md) |  | [optional] 
**SearchLocaleUsed** | [**IsoSearchLocale**](IsoSearchLocale.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

