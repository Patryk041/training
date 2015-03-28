using System.Web.Mvc;

namespace TrainingFive.Areas.Hipek
{
    public class HipekAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Hipek";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Hipek_default",
                "Hipek/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
