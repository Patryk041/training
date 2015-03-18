using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.Exceptions.ErrorsMessages
{
    public static class DateError
    {
       private static Dictionary<string, string> _errorDateMessages = new Dictionary<string, string>()
       {
           {"Bad date.","Departure date is later than the return date."},
           {"Date exists.","The departure date already exists in the collection - person is during the trip."},

       };

        public static string GetDateMessage(string key)
        {
            return _errorDateMessages.Where(item => item.Value.Contains(key)).ToString();
        }
    }
}
