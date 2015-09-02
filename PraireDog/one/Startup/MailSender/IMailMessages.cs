using System.Collections.Generic;

namespace MailSender
{
	public interface IMailMessages
	{
		void SendMail(List<string> mailAddrList, string subject, string body);
	}
}
