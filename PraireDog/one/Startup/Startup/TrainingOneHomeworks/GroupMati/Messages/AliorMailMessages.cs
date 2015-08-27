using System.Net.Mail;

namespace Startup.TrainingOneHomeworks.Mati.Messages
{
    public class AliorMailMessages : MailMessages
    {
        public AliorMailMessages() : base(@"adam.kuba21@gmail.com","smtp.gmail.com",537)
        {
            
        }
        public override string GetSubject(BankMailEnum bankMailEnum)
        {
            return "cokolwiek";
        }

        public override string GetBody(BankMailEnum bankMailEnum)
        {
            return "cokolwiektez";
        }
    }
}