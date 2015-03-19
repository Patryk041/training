using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Toci.Web.Training.Primary.Models.Warrior;

namespace Toci.Web.Training.Primary.Controllers.Warrior
{
    public class GhostRiderController : Controller
    {
        //
        // GET: /GhostRider/

        
        public ActionResult Index(GhostRiderModel model)
        {
            //var model = new GhostRiderModel();

            //new RedirectResult()
            //HttpResponse
            ControllerContext.HttpContext.Response.StatusCode = 403;
            return new HttpNotFoundResult();
            
            //HttpStatusCode

            return View("GhostRider", model);
        }

    }
}
