using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toci.TrainingLibrary.Test.Developers.Warrior.WebApiTesting
{
    [TestClass]
    public class WebApiTest
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }
        }

        [TestMethod]
        public void TestAsync()
        {
            TestHttpClient().Wait();
        }

        public static async Task TestHttpClient()
        {
            using (var client = new HttpClient())
            {
                //http://localhost:49469/products/mg?dupa=2
                client.BaseAddress = new Uri("http://localhost:49469/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync("products/mg?dupa=2");
                if (response.IsSuccessStatusCode)
                {
                    Product[] product = await response.Content.ReadAsAsync<Product[]>();//ReadAsStringAsync(); //<Product>();
                    //Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
                }
            }
        }
    }
}
