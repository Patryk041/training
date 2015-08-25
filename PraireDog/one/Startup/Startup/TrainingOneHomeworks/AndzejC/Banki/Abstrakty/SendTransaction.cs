namespace Startup.TrainingOneHomeworks.AndzejC.Banki.Abstrakty
{
    public abstract class SendTransaction
    {
        public abstract bool InCome();
        public abstract bool OutCome();
        public abstract SendTransaction SendTransfer(Transaction transaction);     
    }
}