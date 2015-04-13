using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainingFive.Common
{
    public class SessionWrapper
    {
        public static void SaveInSession(HttpSessionStateBase session, string key, object setValue)
        {
            //session[key] = setValue;

            //key -> sharding
        }
    }
}