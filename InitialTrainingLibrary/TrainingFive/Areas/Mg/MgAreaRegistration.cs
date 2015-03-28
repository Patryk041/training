using System.Web.Mvc;

namespace TrainingFive.Areas.Mg
{
    public class MgAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Mg";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Mg_default",
                "Mg/{controller}/{action}/{id}",
                new { controller = "home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
