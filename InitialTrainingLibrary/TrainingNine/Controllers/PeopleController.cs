using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;
using TrainingNine.Models;
using TrainingNine.Seeding;

namespace TrainingNine.Controllers
{
    public class PeopleController : ApiController
    {
        //[Route("api/people/betti")]
        [HttpGet]
        public PeopleCollection People([FromUri] FilterModel filters) //FilterModel filters
        {
            var items = Seeder.SeedPeople();

            if (filters.Surname != "")
            {
                return new PeopleCollection(items.Where(item => item.Surname == filters.Surname).ToList());
            }

            return items;
        }

        [Route("api/people/betti")]
        public IHttpActionResult GetJsonList([FromUri] FilterModel filters)
        {
            var items = Seeder.SeedPeople();
            List<People> result;

            if (filters.Surname != "")
            {
                result = items.Where(item => item.Surname == filters.Surname).ToList();
            }
            else
            {
                result = items;
            }

            //return new Xmlres
            return new JsonResult<List<People>>(result, new JsonSerializerSettings(), Encoding.GetEncoding("UTF-8"), this);
        }
    }
}
