using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace TrainingNine.Models
{
    public class PeopleCollection : List<People>//, IHttpActionResult 
    {
        private readonly HttpRequestMessage _request;
   

    public PeopleCollection()
    {
        
        
    }

        public PeopleCollection(List<People> list)
        {
            this.AddRange(list);
            //_request = request;
        }
        
    }
}