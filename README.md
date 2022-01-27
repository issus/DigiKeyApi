# Digi-Key API - the C# library for the Digi-Key Api V3

Search for products and retrieve details and pricing.
Currently Implements:
- All `Product Information` API endpoints and models
- TaxonomySearch

- API version: v3

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core 3.1

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 107.0.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using DigiKey.Api
using DigiKey.Api.Client;
using DigiKey.Api.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            if (ApiClientConfig.Instance.ExpirationDateTime < DateTime.Now)
            {
                Console.WriteLine("OAuth2 Access Token needs to be refreshed.");

                var oAuth2Service = new OAuth2Service();
                var oAuth2AccessToken = await OAuth2Helpers.RefreshTokenAsync();
                if (oAuth2AccessToken.IsError)
                {
                    Console.WriteLine("Refresh token might be invalid, token cannot refresh.");
                    Console.ReadKey();
                    return;
                }
            }

            try
            {
                 var partSearch = new PartSearchApi();
                 var catResponse = await partSearch.Categories();
           
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartSearchApi.Categories: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.digikey.com/Search/v3*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PartSearchApi* | [**Categories**](docs/PartSearchApi.md#categories) | **GET** /Categories | Returns all Product Categories. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category
*PartSearchApi* | [**CategoriesById**](docs/PartSearchApi.md#categoriesbyid) | **GET** /Categories/{categoryId} | Returns Category for given Id. Category Id can be used in KeywordSearchRequest.Filters.TaxonomyIds to restrict a keyword search to a given category
*PartSearchApi* | [**DigiReelPricing**](docs/PartSearchApi.md#digireelpricing) | **GET** /Products/{digiKeyPartNumber}/DigiReelPricing | Calculate the DigiReel pricing for the given DigiKeyPartNumber and RequestedQuantity
*PartSearchApi* | [**KeywordSearch**](docs/PartSearchApi.md#keywordsearch) | **POST** /Products/Keyword | KeywordSearch can search for any product in the Digi-Key catalog.
*PartSearchApi* | [**ManufacturerProductDetails**](docs/PartSearchApi.md#manufacturerproductdetails) | **POST** /Products/ManufacturerProductDetails | Create list of ProductDetails from the matches of the requested manufacturer product name.
*PartSearchApi* | [**Manufacturers**](docs/PartSearchApi.md#manufacturers) | **GET** /Manufacturers | Returns all Product Manufacturers. ManufacturersId can be used in KeywordSearchRequest.Filters.ManufacturerIds to restrict a keyword search to a given Manufacturer
*PartSearchApi* | [**ProductDetails**](docs/PartSearchApi.md#productdetails) | **GET** /Products/{digiKeyPartNumber} | Retrieve detailed product information including real time pricing and availability.
*PartSearchApi* | [**SuggestedParts**](docs/PartSearchApi.md#suggestedparts) | **GET** /Products/{partNumber}/WithSuggestedProducts | Retrieve detailed product information and two suggested products


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ApiErrorResponse](docs/ApiErrorResponse.md)
 - [Model.ApiValidationError](docs/ApiValidationError.md)
 - [Model.AssociatedProduct](docs/AssociatedProduct.md)
 - [Model.BasicProduct](docs/BasicProduct.md)
 - [Model.CategoriesResponse](docs/CategoriesResponse.md)
 - [Model.Category](docs/Category.md)
 - [Model.DigiReelPricingDto](docs/DigiReelPricingDto.md)
 - [Model.Filters](docs/Filters.md)
 - [Model.IsoSearchLocale](docs/IsoSearchLocale.md)
 - [Model.KeywordSearchRequest](docs/KeywordSearchRequest.md)
 - [Model.KeywordSearchResponse](docs/KeywordSearchResponse.md)
 - [Model.KitPart](docs/KitPart.md)
 - [Model.LimitedParameter](docs/LimitedParameter.md)
 - [Model.LimitedTaxonomy](docs/LimitedTaxonomy.md)
 - [Model.ManufacturerInfo](docs/ManufacturerInfo.md)
 - [Model.ManufacturerProductDetailsRequest](docs/ManufacturerProductDetailsRequest.md)
 - [Model.ManufacturersResponse](docs/ManufacturersResponse.md)
 - [Model.MediaLinks](docs/MediaLinks.md)
 - [Model.ParametricFilter](docs/ParametricFilter.md)
 - [Model.PidVid](docs/PidVid.md)
 - [Model.PriceBreak](docs/PriceBreak.md)
 - [Model.Product](docs/Product.md)
 - [Model.ProductDetails](docs/ProductDetails.md)
 - [Model.ProductDetailsResponse](docs/ProductDetailsResponse.md)
 - [Model.ProductWithSuggestions](docs/ProductWithSuggestions.md)
 - [Model.SearchOption](docs/SearchOption.md)
 - [Model.SortDirection](docs/SortDirection.md)
 - [Model.SortOption](docs/SortOption.md)
 - [Model.SortParameters](docs/SortParameters.md)
 - [Model.ValuePair](docs/ValuePair.md)