using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrainingFive.Areas.Mg.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Mg/Home/
        //http://localhost:51763/mg/home

        public ActionResult Index()
        {
            ViewBag.Title = "Mg";
            ViewBag.CurrentDate = DateTime.Now;
            return View("~/Areas/Mg/Views/Index.cshtml");
        }

    }
}
