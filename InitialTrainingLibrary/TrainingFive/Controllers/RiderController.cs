using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingFive.Models;

namespace TrainingFive.Controllers
{
    public class RiderController : Controller
    {
        //
        // GET: /Rider/

        public ActionResult Index(DepartureEntityModel model)
        {
            if (model.ClientId == 0)
            {
                model.ClientId = 1;
            }

            //model.ClientId = 2;

            if (Request.IsAjaxRequest())
            {
                return PartialView("FormPartial", model);
            }

            return View(model);
        }

//        [HttpPost]
//        public ActionResult Save(DepartureEntityModel model)
//        {
//            //zapis
//            return Redirect("index", model);
//        }
    }
}
