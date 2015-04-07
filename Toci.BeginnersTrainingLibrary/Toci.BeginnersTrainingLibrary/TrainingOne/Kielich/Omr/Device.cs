namespace Toci.BeginnersTrainingLibrary.TrainingOne.Kielich.Omr
{
    public abstract class Device
    {
        protected bool Connection;

        protected Battery battery = new Battery();

        public virtual bool IsConnected()
        {
            return Connection;
        }

        public virtual bool IsEnough()
        {
            return battery.IsEnough();
        }

        public virtual bool SetConnection(bool connection)
        {
            return Connection = connection;
        }
    }
}
