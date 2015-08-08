using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.Pacjenct.Interface;

namespace Toci.Hornets.Rzeszow.KSebal.NFZ.EmailContact
{
   public class EmailSender:IContactPossibility<string>
    {
        private LoginData login;
        private SmtpClient klient;

      public  EmailSender(LoginData log)
        {
            login = log;
            klient= new SmtpClient(login.host, login.port)
            {

                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,

                Credentials = new NetworkCredential(login.adressEmail, login.password),
                EnableSsl = true,


            };
        }


        public string GetContactInfo()
        {
            return login.adressEmail;
        }

        public bool SendEmail(string PatientAdressEmail, string subject, string body)
        {

            
            MailMessage message = new MailMessage(login.adressEmail,PatientAdressEmail, subject, body);

            message.BodyEncoding = UTF8Encoding.UTF8;
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            // client.EnableSsl = true;
            klient.Send(message);
            return true;
        }
    }
}
