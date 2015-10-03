using Startup.TrainingOneHomeworks.AndzejC.Banki.Abstrakty;

namespace Startup.TrainingOneHomeworks.AndzejC.Banki.Banks
{
    public class Pkobp : Bank,IBankTransfer
    {
        public Pkobp() : base("PkoBP")
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