using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
//using TrainingFive.Common;
using TrainingFive.Models;

namespace TrainingFive.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult JavascriptEvents(HcModel model)
        {
            //SessionWrapper.SaveInSession(Session, "mg", new Dictionary<string, string>());
            //Session["mg"] = new Dictionary<string, string>();

            return View();
        }

        [ActionName("inaczej")]
        public ActionResult Index(HcModel model)
        {
            var DSd = RouteData.Values["id"];
            var fdsgfds = model.Id;

            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            ViewBag.dbshqgvdhfad = "dsafadsfads";

            dynamic dsafads = new ExpandoObject();// new DynamicJsonArray(new [] {"dsafa"}); //= new {};
            dsafads.dbshqfibvdshfbsfad = model;


            return View("~/Views/Home/Index.cshtml", model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
