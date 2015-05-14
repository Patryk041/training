

using System.Web;
using System.Web.Mvc;

namespace TrainingTen.Attributes
{
    public class CustomAuthorizationAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            
            return false;
            return base.AuthorizeCore(httpContext);
        }
    }
}