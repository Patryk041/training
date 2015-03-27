using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.Exceptions.ErrorsMessages
{
    public class DateError : ErrorsMessagesBase
    {
        public const string KeyBadDate = "Bad date.";
        private const string MessageBadDate = "Departure date is later than the return date.";

        public const string KeyDateExists= "Date exists.";
        private const string MessageDateExists =
            "The departure date already exists in the collection - person is during the trip.";

        public DateError()
        {
            this.ErrorsDictionary.Add(KeyBadDate,MessageBadDate);
            this.ErrorsDictionary.Add(KeyDateExists,MessageDateExists);
        }

        //private static Dictionary<string, string> _errorDateMessages = new Dictionary<string, string>()
        //{
        //    {"Bad date.","Departure date is later than the return date."},
        //    {"Date exists.","The departure date already exists in the collection - person is during the trip."},

        //};

        // public static string GetDateMessage(string key)
        // {
        //     return _errorDateMessages.Where(item => item.Value.Contains(key)).ToString();
        // }
    }
}
