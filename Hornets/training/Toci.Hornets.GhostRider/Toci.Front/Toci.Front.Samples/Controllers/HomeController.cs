using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toci.Front.Samples.Models;
using Toci.Hornets.GhostRider.Kir.BankLoggingMechanism;
using Toci.Hornets.GhostRider.TrainingSeven.Exceptions;

namespace Toci.Front.Samples.Controllers
{
    public class HomeController : Controller
    {

        public HomeController(BusinessLogic logger)
        {
            //var lit = new Li

            
        }

        //[HttpPost]
        public ActionResult Index(HomeModel model)
        {
            //var model = new HomeModel(); // n tier
            // try catch
            //model.WelcomeTextTag = "span";

            try
            {
                BusinessLogic l = new BusinessLogic();
                l.BusinesLogicOperation();
                return null;
            }
            catch (ProjectException e)
            {
                // rekurencja e.InnerException.
            }
            finally
            {
                
            }

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}