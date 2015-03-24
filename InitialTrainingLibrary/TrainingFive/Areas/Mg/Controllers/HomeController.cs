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

        public ActionResult Index()
        {
            return View("~/Areas/Mg/Views/Index.cshtml");
        }

    }
}
