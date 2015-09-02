namespace MailSender
{
	public class MailHandler : MailMessages
	{
		public MailHandler(string host, int port, string username, string password)
	: base(host, port, username, password)
		{
		}
	}
}