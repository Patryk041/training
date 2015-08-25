using Startup.TrainingOneHomeworks.AndzejC.Banki.Abstrakty;

namespace Startup.TrainingOneHomeworks.AndzejC.Banki.Banks
{
    public class Ing : SendTransaction
    {
        public const string BankName = "ING";
        public override bool InCome()
        {
            throw new System.NotImplementedException();
        }

        public override bool OutCome()
        {
            throw new System.NotImplementedException();
        }

        public override SendTransaction SendTransfer(Transaction transaction)
        {
            throw new System.NotImplementedException();
        }
    }
}