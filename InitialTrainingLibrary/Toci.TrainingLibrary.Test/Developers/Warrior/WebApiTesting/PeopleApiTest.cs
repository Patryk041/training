
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toci.TrainingLibrary.Test.Developers.Warrior.WebApiTesting
{
    public class People
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }

    [TestClass]
    public class PeopleApiTest
    {
        [TestMethod]
        public void TestApi()
        {
            TestHttpClient().Wait();
        }

        public static async Task TestHttpClient()
        {
            using (var client = new HttpClient())
            {
                //http://localhost:49602/api/people?surname=Kowalski
                client.BaseAddress = new Uri("http://localhost:49602/");
                client.DefaultRequestHeaders.Accept.Clear();
               // client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync("api/people?surname=Kowalski&_ext=json");
                if (response.IsSuccessStatusCode)
                {
                    People[] product = await response.Content.ReadAsAsync<People[]>();//ReadAsStringAsync(); //<Product>();
                    //Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
                }
            }
        }
    }
}
