namespace Toci.BeginnersTrainingLibrary.TrainingOne.Kielich.Omr
{
    public abstract class Power
    {
        protected bool Connection;
        protected bool Currency;

        public abstract bool IsConnected();
        public abstract bool IsEnough();
        public abstract bool SetConnection(bool connection);
    }
}
