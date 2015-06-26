using Toci.Hornets.Opole.Startup.Omr.UCantTouchThis.Base;

namespace Toci.Hornets.Opole.Startup.Omr.UCantTouchThis
{
    public abstract class BaseLamp : ILamp
    {
        public BaseLightSource LightSource;

        public BaseType LampBaseType;

        public string Owner;
        public int Color;
        public int Shape;
        public int Height;

        public abstract bool ChangeState();
    }
}