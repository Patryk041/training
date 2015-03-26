using System.Web.Mvc;

namespace TrainingFive.Areas.Domi
{
    public class DomiAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Domi";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Domi_default",
                "Domi/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
