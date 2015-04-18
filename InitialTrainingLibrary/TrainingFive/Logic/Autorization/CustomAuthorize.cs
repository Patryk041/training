using System;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace TrainingFive.Logic.Autorization
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //base.OnAuthorization(filterContext);
            if (filterContext.Controller.ControllerContext.HttpContext.Session != null && filterContext.Controller.ControllerContext.HttpContext.Session["power"] == null)
            {
                base.OnAuthorization(filterContext);
                return;
            }

            if (!(bool) filterContext.Controller.ControllerContext.HttpContext.Session["power"])
            {
                throw new Exception();
            }

            //var user = filterContext.Controller.ControllerContext.RouteData.Values["UserName"];
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return base.AuthorizeCore(httpContext);
        }

        
    }
}