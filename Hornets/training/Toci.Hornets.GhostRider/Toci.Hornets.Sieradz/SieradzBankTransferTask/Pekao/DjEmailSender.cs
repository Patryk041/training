using System;
using System.Net.Mail;
using System.Text;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.Pekao
{
    public static class DjEmailSender
    {
        public static bool SendEmail(string subject, string body)
        {
            var client = new SmtpClient
            {
                Port = 587,
                Host = "smtp.gmail.com",
                EnableSsl = true,
                Timeout = 10000,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential("deejaytocihornets@gmail.com", "2#3KZ9DG@kpJ")
            };

            var mm = new MailMessage("deejaytocihornets@gmail.com", "mrtruskawa@gmail.com", subject, body)
            {
                BodyEncoding = Encoding.UTF8,
                DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            };

            try
            {
                client.Send(mm);
                return true;
            }
            catch (Exception)
            {
                return false;
            }         
        }
    }
}