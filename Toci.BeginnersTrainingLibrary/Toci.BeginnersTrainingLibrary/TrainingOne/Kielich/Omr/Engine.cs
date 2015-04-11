namespace Toci.BeginnersTrainingLibrary.TrainingOne.Kielich.Omr
{
    public abstract class Engine
    {
        protected bool Connection;
        protected bool Work;
        protected bool Volt;

        public abstract bool IsConnected();
        public abstract bool IsWorking();
        public abstract bool IsEnough();

        public abstract bool SetConnection(bool connection);
        public abstract bool SetWork(bool work);
    }
}
