using System.Configuration;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Kielich.Omr
{
    public class Battery : Power
    {
        private const int CriticalLevel = 10;

        public bool Capacity(int currency)
        {
            return  Currency = currency > CriticalLevel;
        }

        public override bool IsEnough()
        {
            return Currency;
        }

        public override bool IsConnected()
        {
            return Connection;
        }

        public override bool SetConnection(bool connection)
        {
            return Connection = connection;
        }
    }
}
