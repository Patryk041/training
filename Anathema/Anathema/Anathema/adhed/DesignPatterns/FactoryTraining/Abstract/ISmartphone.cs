using System.Collections.Specialized;

namespace Anathema.adhed.DesignPatterns.FactoryTraining
{
    public interface ISmartphone
    {

        void TryTurnOn();

        string Name { get; set; }
        int DisplaySize { get; set; }
        int BatteryLvl { get; set; }
    }
}