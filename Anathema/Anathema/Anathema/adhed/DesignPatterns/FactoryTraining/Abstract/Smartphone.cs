namespace Anathema.adhed.DesignPatterns.FactoryTraining
{
    public abstract class Smartphone : ISmartphone
    {
        public virtual void TryTurnOn()
        {
            if (BatteryLvl > 5)
            {
                TurnOn();
            }
        }

        public virtual void TurnOn()
        {
            BatteryLvl--;
        }

        public string Name { get; set; }
        public int DisplaySize { get; set; }
        public int BatteryLvl { get; set; }
    }
}