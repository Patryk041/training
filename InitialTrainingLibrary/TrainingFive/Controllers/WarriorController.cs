using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using TrainingFive.Logic;
using TrainingFive.Models;

namespace TrainingFive.Controllers
{
    public class WarriorController : Controller
    {
        //
        // GET: /Warrior/

        //public WarriorController(IDeparturesLogic deplogic)

        [HttpGet]
        public ActionResult Index(WarriorModel model)
        {
            
            //if (Request.IsAjaxRequest())

            DeparturesLogic logic = new DeparturesLogic();

            if (Session["dysq"] != null)
            {
                model = (WarriorModel)Session["dysq"];
            }

            model.ListOfDepartures = logic.GetDepartures();

            //return Redirect("http://google.pl");

            return View(model);
        }

        [HttpPost]
        public ActionResult Save(WarriorModel model)
        {
            //save

            //Response.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            //Response.
            Session.Add("dysq", model);
            
            return Redirect("index");
        }

        
        public ActionResult SitoiMgToLubia()
        {
            var json = new JsonResult();
            json.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            //json.Data = new { chmura = "dsafad", sito = "rey7ewqasyi", szyfrant = "dbcsqdhifrgt2yefgyeqdabfvdwgy"};
            json.Data = new Dictionary<string, string>
            {
                { "dysq", "whatever"},
                { "chmura", "sito"},
                { "szyfrant", "mg"},
                { "errMsg", "costam"},
            };
            //HttpContext
            //Response.Headers.Add("Location", "http://google.pl");
            Response.StatusCode = 409;

            //Session.
            //Request.Cookies

            return json;
        }

    }
}
