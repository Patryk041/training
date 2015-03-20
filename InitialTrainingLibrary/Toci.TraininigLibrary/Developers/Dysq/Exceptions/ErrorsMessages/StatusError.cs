using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.Exceptions.ErrorsMessages
{
    public class StatusError : ErrorsMessagesBase
    {

        public const string KeyAciveStatus = "Active status.";

        private const string MessageActiveStatus =
            "The departure date should be from past. The return date should be in future.";

        public const string KeyDeparturingStatus = "Departuring status.";
        private const string MessageDeparturingStatus = "The departure date should be during 7 days in future.";

        public const string KeyExperiencedStatus = "Experienced status";
        private const string MessageExperiencedStatus = "The dates should be from the past.";

        public const string KeyInadequateStatus = "Inadequate status.";
        private const string MessageInadequateStatus = "The employment date should be from the past.";

        public const string KeyNewStatus = "New status.";
        private const string MessageNewStatus =
            "This person have once appointment to the one client and should be more than 7 days before departure.";
        
        public const string KeyRevisitingStatus = "Revisiting status.";
        private const string MessageRevisitingStatus =
            "This person should be more than 7 days before departure and should be one record with experienced status in collection for client id.";

        public StatusError()
        {
            this.ErrorsDictionary.Add(KeyAciveStatus,MessageActiveStatus);
            this.ErrorsDictionary.Add(KeyDeparturingStatus,MessageDeparturingStatus);
            this.ErrorsDictionary.Add(KeyExperiencedStatus,MessageExperiencedStatus);
            this.ErrorsDictionary.Add(KeyInadequateStatus,MessageInadequateStatus);
            this.ErrorsDictionary.Add(KeyNewStatus,MessageNewStatus);
            this.ErrorsDictionary.Add(KeyRevisitingStatus,MessageRevisitingStatus);
        }

        // private static Dictionary<string, string> _errorStatusMessages = new Dictionary<string, string>()
        //{
        //    {"Active status.","The departure date should be from past. The return date should be in future."},
        //    {"Departuring status.","The departure date should be during 7 days in future."},
        //    {"Experienced status.","The dates should be from the past."},
        //    {"Inadequate status.","The employment date should be from the past."},
        //    {"New status.","This person have once appointment to the one client and should be more than 7 days before departure."},
        //    {"Revisiting status.","This person should be more than 7 days before departure and should be one record with experienced status in collection for client id."},
        //};

        // public static string GetStatusMessage(string key)
        // {
        //     return _errorStatusMessages.Where(item => item.Value.Contains(key)).ToString();
        // }
    }
}
