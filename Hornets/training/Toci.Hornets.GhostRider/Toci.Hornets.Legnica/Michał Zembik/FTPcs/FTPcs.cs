using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Legnica.Michał_Zembik.FTPcs
{
    class FTPcs
    {

        public bool Send(string sourcefilepath, string desinationfilepath, string login, string pass)
        {
            var sender = new SendFile();
            return sender.Send(sourcefilepath, desinationfilepath, login, pass); ;
        }

        public string Get(string filepath)
        {
            var geter = new GetFile();
            return geter.Get(filepath);
        }

    }
}
