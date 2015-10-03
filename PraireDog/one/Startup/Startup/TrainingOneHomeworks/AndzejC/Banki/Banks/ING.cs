using Startup.TrainingOneHomeworks.AndzejC.Banki.Abstrakty;

namespace Startup.TrainingOneHomeworks.AndzejC.Banki.Banks
{
    public class Ing : Bank, IBankTransfer
    {
        public Ing() : base("Ing"){}

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