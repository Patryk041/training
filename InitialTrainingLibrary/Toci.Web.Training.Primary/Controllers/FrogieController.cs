using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toci.Db.DbVirtualization.MsSqlQuery;
using Toci.Db.Interfaces;
using Toci.Web.Training.Primary.Models;

namespace Toci.Web.Training.Primary.Controllers
{
    public class FrogieController : Controller
    {
        //public FrogieController(IDbHandle handle)
        //public FrogieController(MsSqlDelete handle)
        //{
            
        //}
        //
        // GET: /Frogie/

        public ActionResult Zaba(FrogieModel model)
        {
            //Activator.CreateInstance("assembly", "FrogieController");

            return View(model);
        }

        public ActionResult Test(string warrior, string data, int test)
        {
            return null;
        }
    }
}
