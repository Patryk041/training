namespace Startup.TrainingOneHomeworks.AndzejC.Banki.Abstrakty
{
    public class Bank
    {
        public Bank(string bankName)
        {
            BankName = bankName;
        }

        public string BankName{get; private set; }

    }
}