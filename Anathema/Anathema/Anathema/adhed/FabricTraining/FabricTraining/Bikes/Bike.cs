namespace FabricTraining.Bikes
{
    public abstract class Bike : IBike
    {
        protected Bike(int wheelSize, int frameSize)
        {
            WheelSize = wheelSize;
            FrameSize = frameSize;
        }

        protected Bike() {}

        public bool Ride()
        {
            return true;
        }

        public int WheelSize { get; set; }
        public int FrameSize { get; set; }
        public string Description { get; set; }
    }
}