using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrainingFive.Areas.Dysq.Controllers
{
    public class MyController : Controller
    {
        //
        // GET: /Dysq/My/

        public ActionResult Index()
        {
            return View("~/Areas/Dysq/Views/Index.cshtml");
        }

    }
}
