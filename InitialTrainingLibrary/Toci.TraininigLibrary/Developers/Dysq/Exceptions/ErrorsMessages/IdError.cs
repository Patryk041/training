using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.Exceptions.ErrorsMessages
{
    public static class IdError
    {
        private static Dictionary<string, string> _errorIdMessages = new Dictionary<string, string>()
        {
            {"Bad id.","Section id doesn't exist for this client id."},
        };

        public static string GetClientIdMessage(string key)
        {
            return _errorIdMessages.Where(item => item.Value.Contains(key)).ToString();
        }
    }
}
