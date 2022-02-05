# Digi-Key API - the C# library for the Digi-Key Api V3

Search for products and retrieve details and pricing.
Currently Implements:
- All `Product Information` API endpoints and models
- TaxonomySearch

- API version: v3

<a name="frameworks-supported"></a>
## Frameworks supported
Configured for .NET 6 however will happily run under .NET Core 3.1, .NET Standard 2.0, or the full .NET framework.

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 107.0.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

I recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```
Visual Studio will also restore these automatically when building the solution for the first time.

<a name="getting-started"></a>
## Getting Started

This example uses the `apiclient.config` file for loading configuration details. Use the `DigiKey.Api.OAuth2ConsoleClient` project to generate a config file.

You do not need to explicitly load the config file, it will look for it and read it automatically.


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

## Using a Custom Configuration Source

You can create your own `IApiClientConfigHelper` to load a configuration from a database or other source.

The ApiClientConfig.Instance needs to be before any other ApiClientConfig or API class is called.

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
            // set configuration source to custom database source
            ApiClientConfig.Instance = new DigiKeyDatabaseConfiguration();

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

## Logging API Calls

The library contains an event you can subscribe to which will give you the request and response objects if you want to log them for debugging or testing purposes.

```
// Subscribe to API call completed
ApiClient.Instance.ApiCallCompleted += (request, response) =>
{
    LogApiCall(request, response);
};
```


## Keyword Search
Here's a complete example keyword search which will bring up the first 50 results from a category.
```
var partSearch = new PartSearchApi();

List<int> taxonomy = new List<int>();
// category to search
taxonomy.Add(categoryId);
var filters = new Filters(taxonomy);

// sorting options
var sort = new SortParameters(SortOption.SortByQuantityAvailable, SortDirection.Descending, 0);

// search configuration
var searchOptions = new List<SearchOption>();
searchOptions.Add(SearchOption.ExcludeNonStock);
searchOptions.Add(SearchOption.InStock);
searchOptions.Add(SearchOption.CollapsePackagingTypes); // doesn't seem to do anything

// run search
var results = await partSearch.KeywordSearch(new KeywordSearchRequest()
{
    Keywords = "", // add your keywords here
    RecordCount = 50,
    RecordStartPosition = page, // 0 based page number
    ExcludeMarketPlaceProducts = true,
    Filters = filters,
    Sort = sort,
    SearchOptions = searchOptions
});
```

## Rate Limit Hit
If you hit the burst or daily rate limit, you can wait until you can make requests again. The `ApiClient.Instance.BurstLimited` and `ApiClient.Instance.RateLimited` properties are only set if you are rate limited.

Rather than hit the rate limit, you can check how many requests you have remaining with the `ApiClient.Instance.RateLimitRemaining` property. This does not indicate burst limits.

```
if (ApiClient.Instance.BurstLimited != null)
{
    Console.WriteLine($"Burst Rate limited on {crawlCategory.CategoryName}. Resume in {ApiClient.Instance.BurstLimited.Reset}.");

    await Task.Delay((ApiClient.Instance.BurstLimited.Reset * 1000) + 2000);
}

if (ApiClient.Instance.RateLimited != null)
{
    Console.WriteLine($"Daily Rate limited on {crawlCategory.CategoryName}. Resume after {ApiClient.Instance.RateLimited.ResetTime} GMT.");

    await Task.Delay((ApiClient.Instance.RateLimited.RetryAfter * 1000) + 60000);
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

See [**Docs**](docs/) for documentation on endpoints and models.
