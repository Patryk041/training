namespace Startup.TrainingOneHomeworks.marcin022
 
{
    public abstract class BankAbstract
    {
        protected string Name;
        protected string AccNumber;

        public virtual string ShowName()
        {
            return Name;
        }
    }
}