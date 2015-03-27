using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toci.Web.Training.Primary.Models;
using System.Reflection;

namespace Toci.Web.Training.Primary.Controllers
{
    public class RobsonController : Controller
    {
        //
        // GET: /Robson/

        public ActionResult Index(RobsonModel model)
        
        {
            string url = Request.RawUrl;
            string queryString = url.Substring(url.IndexOf('?')+1);

            Dictionary<string, string> dict = queryString.Split(new[] { '&' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Split('=')).ToDictionary(x => x[0], y => y[1]);


            var fields = model.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach(var field in fields)
            {
                if (!dict.Keys.Contains(field.Name)) continue;
                string fieldValue = dict[field.Name];
                field.SetValue(model, fieldValue);
            }

            return View(model);
        }

    }
}
