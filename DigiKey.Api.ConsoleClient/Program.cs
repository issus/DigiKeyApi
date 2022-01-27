using DigiKey.Api.Client;
using DigiKey.Api.Configuration;
using DigiKey.Api.OAuth2;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace DigiKey.Api.ConsoleClient
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

            await Categories();



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press [Any Key] to exit...");
            Console.ReadKey();
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
