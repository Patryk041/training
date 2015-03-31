using System.Web.Mvc;

namespace TrainingFive.Areas.Soltys
{
    public class SoltysAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Soltys";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Soltys_default",
                "Soltys/{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional}); //, area = "Soltys" 
//                new[] { "TrainingFive.Controllers" }
                //namespaces: new[] { "TrainingFive.Areas.Soltys.Controllers" }
        }
    }
}
