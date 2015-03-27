using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toci.Web.Training.Primary.Models;

namespace Toci.Web.Training.Primary.Controllers
{
    public class WarriorController : Controller
    {
        //
        // GET: /Warrior/

        public ActionResult Index(WarriorModel model)
        {

            //

            return View(model);
        }

        public ActionResult GhostRider(int id, string test)
        {
            return null;
        }
    }
}
