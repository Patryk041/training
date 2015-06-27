namespace Toci.Hornets.Opole.Startup.Omr.UCantTouchThis
{
    public abstract class OilSource : BaseLightSource
    {
        public int FuelUsage;
        protected int FuelTank;

        public abstract void Refuel();
    }
}