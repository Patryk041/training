using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Legnica.Michał_Zembik.FTPcs
{
    public class FTPcs
    {
        private string _login, _pass;
        public FTPcs(string login, string pass)
        {
            _login = login;
            _pass = pass;
        }

        public bool Send(string sourcefilepath, string desinationfilepath, string login, string pass)
        {
            var sender = new SendFile();
            return sender.Send(sourcefilepath, desinationfilepath, login, pass); 
        }

        public string Get(string sourcefilepath)
        {
            var geter = new GetFile();
            return geter.Get(sourcefilepath,_login,_pass);
        }

    }
}
