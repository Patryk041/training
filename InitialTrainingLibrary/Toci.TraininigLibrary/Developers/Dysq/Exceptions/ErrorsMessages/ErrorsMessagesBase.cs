using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.Exceptions.ErrorsMessages
{
    public  class ErrorsMessagesBase
    {
        protected Dictionary<string,string> ErrorsDictionary = new Dictionary<string, string>();

        public string GetMessage(string key)
        {
            return ErrorsDictionary.Where(item => item.Key == key).ToDictionary(item => item.Key, item => item.Value).First().Value;
        }


    }
}
