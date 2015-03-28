using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrainingFive.Areas.Hipek.Controllers
{
    public class HomeHipekController : Controller
    {
        //
        // GET: /Hipek/HomeHipek/

        public ActionResult Index()
        {
            return View("~/Areas/Hipek/Views/Index.cshtml");
        }

    }
}
