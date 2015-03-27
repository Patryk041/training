using System.Web.Mvc;

namespace TrainingFive.Areas.Dysq
{
    public class DysqAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Dysq";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Dysq_default",
                "Dysq/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
