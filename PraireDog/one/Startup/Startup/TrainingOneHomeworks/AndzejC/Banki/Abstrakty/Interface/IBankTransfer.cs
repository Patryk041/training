namespace Startup.TrainingOneHomeworks.AndzejC.Banki.Abstrakty
{
    public interface IBankTransfer
    {

        bool InCome(Transaction transaction);
        bool OutCome(Transaction transaction); 
    }
}