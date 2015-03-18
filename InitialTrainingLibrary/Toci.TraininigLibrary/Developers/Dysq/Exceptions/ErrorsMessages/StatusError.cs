using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.Exceptions.ErrorsMessages
{
    public static class StatusError
    {
        private static Dictionary<string, string> _errorStatusMessages = new Dictionary<string, string>()
       {
           {"Active status.","The departure date should be from past. The return date should be in future."},
           {"Departuring status.","The departure date should be during 7 days in future."},
           {"Experienced status.","The dates should be from the past."},
           {"Inadequate status.","The employment date should be from the past."},
           {"New status.","This person have once appointment to the one client and should be more than 7 days before departure."},
           {"Revisiting status.","This person should be more than 7 days before departure and should be one record with experienced status in collection for client id."},
       };

        public static string GetStatusMessage(string key)
        {
            return _errorStatusMessages.Where(item => item.Value.Contains(key)).ToString();
        }
    }
}
