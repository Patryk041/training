using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using Toci.Dal.Models;
using Toci.Db.Clients;
using Toci.Db.ClusterAccess;
using Toci.Db.DbVirtualization.PostgreSqlQuery;
using Toci.TraininigLibrary.Developers.Warrior.Db.Models;
using TrainingFive.Logic;
using TrainingFive.Logic.Autorization;
using TrainingFive.Models;

namespace TrainingFive.Controllers
{
    public class WarriorController : Controller
    {
        //
        // GET: /Warrior/

        //public WarriorController(IDeparturesLogic deplogic)

        [HttpGet]
        public ActionResult Index()
        {
            WarriorModel model = new WarriorModel();

            return View(model);
        }

        //[CustomAuthorize]
        [ValidateAntiForgeryToken]
    [HttpPost]
        //[OutputCache]
        public ActionResult Index(WarriorModel model)
        {
            //if (Session != null && Session["power"] != null && (bool)Session["power"])
           // {

                //DbHandleFactory
                BankAccountTransferModel transfer = new BankAccountTransferModel();

                var postgreDbHandle = new DbHandle(new PostgreSqlClient("postgres", "beatka", "localhost", "postgres"),
                    new PostgreSqlSelect(), new PostgreSqlInsert(), new PostgreSqlUpdate(), new PostgreSqlDelete());

                //if (Request.IsAjaxRequest())

                DeparturesLogic logic = new DeparturesLogic();

                if (Session["dysq"] != null)
                {
                    //model = (WarriorModel) Session["dysq"];
                }

                model.ListOfDepartures = logic.GetDepartures();

            if (model.GhostRider != null && model.GhostRider.Length > 1)
            {
                transfer.Nazwa = model.GhostRider;
                transfer.Id = new Random().Next(100);
                postgreDbHandle.InsertData(transfer);

                transfer.SetWhere(BankAccountTransferModel.NAZWA);
                var dataset = postgreDbHandle.GetData(transfer);
                model.TransferLists = dataset;

                model.TransferList = transfer.GetDataRowsList(dataset);
            }
            //}

            //return Redirect("http://google.pl");

            return View(model);
        }

        //[HttpPost]
        //public ActionResult Save(WarriorModel model)
        //{
        //    //save

        //    //Response.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
        //    //Response.
        //    Session.Add("dysq", model);
            
        //    return Redirect("index");
        //}

        
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
