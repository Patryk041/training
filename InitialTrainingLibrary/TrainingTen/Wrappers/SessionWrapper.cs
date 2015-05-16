using System.Web;
using System.Web.SessionState;

namespace TrainingTen.Wrappers
{
    public class SessionWrapper
    {
        public const string LoginName = "LoginName";

        protected HttpSessionState Session = HttpContext.Current.Session;

        public object GetElement(string key)
        {
            return Session[key];
        }

        public void SetElement(string key, object element)
        {
            Session[key] = element;
        }

        public bool KeyExist(string key)
        {
            return Session[key]!=null;
        }
    }
}