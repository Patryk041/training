using Startup.TrainingOneHomeworks.AndzejC.Banki.Abstrakty;

namespace Startup.TrainingOneHomeworks.AndzejC.Banki.Banks
{
    public class NarodowyBankPolski : Bank,IBankTransfer
    {

        public NarodowyBankPolski() : base("Narodowy Bank Polski")
        {
        }

        public bool InCome(Transaction transaction)
        {
            throw new System.NotImplementedException();
        }

        public bool OutCome(Transaction transaction)
        {
            throw new System.NotImplementedException();
        }
    }
}