namespace Toci.BeginnersTrainingLibrary.TrainingOne.Kielich.Omr
{
    public abstract class Machine : Device
    {
        protected bool Work;

        public abstract bool IsWorking();
        public abstract bool SetWork(bool work);
    }
}
