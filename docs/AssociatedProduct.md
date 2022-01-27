# IO.Swagger.Model.AssociatedProduct
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductUrl** | **string** | Full URL of the Digi-Key catalog page to purchase the product. This is based on your provided Locale values. | [optional] 
**ManufacturerPartNumber** | **string** | The manufacturer part number. Note that some manufacturer part numbers may be used by multiple manufacturers for  different parts. | [optional] 
**MinimumOrderQuantity** | **int?** | The minimum quantity to order from Digi-Key. | [optional] 
**NonStock** | **bool?** | Indicates this product is a non stock product. | [optional] 
**Packaging** | [**PidVid**](PidVid.md) |  | [optional] 
**QuantityAvailable** | **int?** | Quantity of the product available for immediate sale. | [optional] 
**DigiKeyPartNumber** | **string** | The Digi-Key part number. | [optional] 
**ProductDescription** | **string** | Catalog description of the product. | [optional] 
**UnitPrice** | **double?** | The price for a single unit of this product. | [optional] 
**Manufacturer** | [**PidVid**](PidVid.md) |  | [optional] 
**ManufacturerPublicQuantity** | **int?** | Quantity of this product available to order from manufacturer. | [optional] 
**QuantityOnOrder** | **int?** | Quantity of this product ordered but not immediately available. | [optional] 
**DKPlusRestriction** | **bool?** | If true- this product is not available for purchase through the Ordering API - it must be purchased through the  Digi-Key web site | [optional] 
**Marketplace** | **bool?** | Product is a Marketplace product that ships direct from the supplier.  A separate shipping fee may apply | [optional] 
**SupplierDirectShip** | **bool?** | If true- this product is shipped directly from the Supplier | [optional] 
**PimProductName** | **string** | Pim name for the product | [optional] 
**Supplier** | **string** | The Supplier is the provider of the products to Digi-Key and some cases the customer directly. | [optional] 
**SupplierId** | **int?** | Id for Supplier | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

