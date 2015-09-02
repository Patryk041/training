using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace MailSender
{
	public class MailMessages
	{
		#region vars
		private MailMessage _mailMessage;
		private SmtpClient _smtpClient = new SmtpClient();
		private string _myMailAddr;
		#endregion

		public MailMessages(string host, int port, string username, string password)
		{
			_myMailAddr = username;
			#region smtp_conf
			_smtpClient.Host = host;
			_smtpClient.Port = port;
			_smtpClient.EnableSsl = true;
			_smtpClient.UseDefaultCredentials = false;
			_smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;


			_smtpClient.Credentials = new
			System.Net.NetworkCredential(username, password);


			#endregion
		}

		public void SendMail(List<string> mailAddrList, string subject, string body)
		{
			foreach (var addr in mailAddrList)
			{
				try
				{
					#region send mails

					_mailMessage = new MailMessage(_myMailAddr, addr);
					_mailMessage.Subject = subject;
					_mailMessage.Body = body;
					_smtpClient.Send(this._mailMessage);

					#endregion
				}
				catch (Exception e) { }
			}

		}
	}
}