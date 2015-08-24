namespace Startup.TrainingOneHomeworks.AndzejC.Banki.Abstrakty
{
    public abstract class SendTransaction
    {
        public abstract bool SendTransfer(Transaction transaction);     
    }
}