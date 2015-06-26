

using System.Web;
using System.Web.Mvc;
using TrainingTen.Managers;

namespace TrainingTen.Attributes
{
    public class CustomAuthorizationAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var test = httpContext;

            if (httpContext.Request.IsAjaxRequest())
            {
                return false;
            }

            UserManager userManager = new UserManager();
            return userManager.IsLogged();
        }
    }
}