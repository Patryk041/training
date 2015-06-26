using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;
using TrainingEight.Models;

namespace TrainingEight.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[] 
        { 
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };

        [Route("products/mg")]
        [HttpGet]
        public IHttpActionResult Mg(string dupa)
        {
            return new JsonResult<Product[]>(products, new JsonSerializerSettings(), Encoding.GetEncoding("UTF-8"), this);
        }

        [Route("products/warrior")]
        public IHttpActionResult GetWarrior(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [Route("product/mg")]
        //[HttpGet]
        public IHttpActionResult GetWhatever(int id)
        {
            return new JsonResult<Product>(products[1], new JsonSerializerSettings(), Encoding.GetEncoding("UTF-8"), this);
        }
    }
}
