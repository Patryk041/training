using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;
using Toci.Web.Training.Primary.Models.Mg;

namespace Toci.Web.Training.Primary.Controllers.MgControllers
{
    public class MgController : Controller
    {
        //
        // GET: /Mg/

        public ActionResult MgQueryStringAction(string number,string name,string surName,string description)
        {

            //http://localhost:64968/Mg/MgQueryStringAction?number=2&name=ahmed&surName=kowalski&description=binladen


            MgFillReflecionModel fillReflecionModel = new MgFillReflecionModel(new Dictionary<string, string>()
            {
                {"NUMBER",number},
                {"NAME", name},
                {"SURNAME", surName},
                {"DESCRIPTION", description}

            });

            

            return View(fillReflecionModel.GetFilledMgReflectionModelModel());
        }

    }
}
