using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingTen.Attributes;

namespace TrainingTen.Controllers
{
    public class WarriorController : Controller
    {
        // GET: Warrior
        [CustomAuthorization]
        public ActionResult Index()
        {
            return View();
        }
    }
}