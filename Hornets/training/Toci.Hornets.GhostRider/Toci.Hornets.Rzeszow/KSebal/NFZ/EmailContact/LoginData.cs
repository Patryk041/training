using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Rzeszow.KSebal.NFZ.EmailContact
{
    public class LoginData
    {
        public string password { get; set; }
        public string adressEmail { get;set; }
        public int port { get;set;}
        public string host { get; set; }
      
      public  LoginData(string pass, string maill, int port, string hst)
      {
          
              password = pass;
              adressEmail = maill;
              this.port = port;
              host = hst;
          


           
        }

        

    }
}
