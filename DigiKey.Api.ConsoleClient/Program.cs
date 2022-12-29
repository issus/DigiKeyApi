using OriginalCircuit.DigiKey.Api.Configuration;
using OriginalCircuit.DigiKey.Api.Model;
using OriginalCircuit.DigiKey.Api.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginalCircuit.DigiKey.Api.ConsoleClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Digi-Key API Console Client Sample");

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

            //await Categories();
            //await KeywordSearch();
            //await Manufacturers();
            await ProductDetails();
            //await SuggestedParts();
            //await Taxonomy();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press [Any Key] to exit...");
            Console.ReadKey();
        }

        private static async Task Taxonomy()
        {
            var taxonomy = new TaxonomyApi();
            var result = await taxonomy.TaxonomySearch("60");
            Console.WriteLine($"Category URL: {result}");
        }

        private static async Task SuggestedParts()
        {
            var partSearch = new PartSearchApi();
            var results = await partSearch.SuggestedParts("478-1114-1-ND");

            Console.WriteLine("╔══[SUGGESTED PARTS]══════════════════════════════════");
            Console.WriteLine($"║  FOR: {results.Product.Manufacturer.Value} {results.Product.ManufacturerPartNumber} [{results.Product.DigiKeyPartNumber}]");
            Console.WriteLine("║");

            foreach (var product in results.SuggestedProducts)
            {
                Console.WriteLine($"╠═══[{product.DigiKeyPartNumber}] {product.Manufacturer.Value.ToUpper()} - {product.ManufacturerPartNumber}]═════════════════");
                Console.WriteLine($"║ ├─[DESC] {product.ProductDescription}");
                Console.WriteLine($"║ ├─[Price] {product.UnitPrice}@1");
                Console.WriteLine($"║ └─[Stock] {product.QuantityAvailable}");
            }
            Console.WriteLine($"╚══[{results.SuggestedProducts.Count} PRODUCTS]════════════════");
        }

        private static async Task ProductDetails()
        {
            var partSearch = new PartSearchApi();
            var results = await partSearch.ProductDetails("478-1114-1-ND");

            Console.WriteLine($"╔══[{results.ManufacturerPartNumber.ToUpper()}]══════════════════════════════════");
            Console.WriteLine(results);
        }

        private static async Task Manufacturers()
        {
            var partSearch = new PartSearchApi();
            var result = await partSearch.Manufacturers();

            Console.WriteLine("╔══[MANUFACTURERS]══════════════════════════════════");

            var lastManufacurer = result.Manufacturers.Last();

            foreach (var manufacturer in result.Manufacturers.OrderBy(m => m.Id))
            {
                Console.WriteLine($"╠═[{manufacturer.Id}] {manufacturer.Name}");

                if (manufacturer == lastManufacurer)
                    Console.WriteLine($"╚══[{result.Manufacturers.Count} MANUFACTURERS]════════════════");
                else
                    Console.WriteLine("║");
            }
        }

        private static async Task KeywordSearch()
        {
            List<int> taxonomy = new List<int>();
            taxonomy.Add(60);

            var filters = new Filters(taxonomy);

            var sort = new SortParameters(SortOption.SortByQuantityAvailable, SortDirection.Descending, 0);

            var searchOptions = new List<SearchOption>();
            searchOptions.Add(SearchOption.ExcludeNonStock);
            searchOptions.Add(SearchOption.InStock);
            searchOptions.Add(SearchOption.CollapsePackagingTypes);

            var partSearch = new PartSearchApi();

            var results = await partSearch.KeywordSearch(new KeywordSearchRequest()
            {
                Keywords = "",
                RecordCount = 50,
                RecordStartPosition = 0,
                ExcludeMarketPlaceProducts = true,
                Filters = filters,
                Sort = sort,
                SearchOptions = searchOptions
            });

            Console.WriteLine($"Product Count: {results.ProductsCount}");
            Console.WriteLine("╔══[PRODUCTS]══════════════════════════════════");
            foreach (var result in results.Products)
            {
                Console.WriteLine($"╠═[{result.DigiKeyPartNumber}] {result.Manufacturer.Value} - {result.ManufacturerPartNumber}");
                Console.WriteLine($"║ ├─[Desc]  {result.ProductDescription}");
                Console.WriteLine($"║ ├─[Price] {result.UnitPrice}@1");
                Console.WriteLine($"║ └─[Stock] {result.QuantityAvailable}");
            }
            Console.WriteLine($"╚══[{results.Products.Count} PRODUCTS]════════════════");
        }

        private static async Task Categories()
        {
            var partSearch = new PartSearchApi();
            var catResponse = await partSearch.Categories();
            Console.WriteLine($"Product Count: {catResponse.ProductCount}");
            Console.WriteLine("╔══[CATEGORIES]══════════════════════════════════");

            var lastCategory = catResponse.Categories.Last();

            foreach (var category in catResponse.Categories)
            {
                Console.WriteLine($"╠═[{category.CategoryId}] {category.Name}");

                var lastChild = category.Children.Last();
                foreach (var child in category.Children)
                {
                    var treeChar = (child == lastChild) ? '└' : '├';
                    Console.WriteLine($"║ {treeChar}─[{child.CategoryId}] {child.Name}");
                }

                if (category == lastCategory)
                    Console.WriteLine($"╚══[{catResponse.Categories.Count} CATEGORIES]════════════════");
                else
                    Console.WriteLine("║");
            }
        }
    }
}
