using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace TrainingNine.Attributes
{
    public class OwnAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            //actionContext
            //HttpContext.Current.Session

            return base.IsAuthorized(actionContext);
        }
    }
}