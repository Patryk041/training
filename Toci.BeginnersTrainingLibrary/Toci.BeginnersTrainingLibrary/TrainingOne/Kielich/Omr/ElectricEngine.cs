using System.Net.Configuration;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Kielich.Omr
{
    public class ElectricEngine : Engine
    {
        private const int MaxVoltLevel = 12;
        private const int MinVoltLevel = 10;

        public override bool IsConnected()
        {
            return Connection;
        }

        public override bool IsWorking()
        {
            return Work;
        }

        public override bool IsEnough()
        {
            return Volt;
        }

        public bool Voltage(int volt)
        {
            return Volt = volt >= MinVoltLevel && volt <= MaxVoltLevel;
        }

        public override bool SetConnection(bool connection)
        {
            return Connection = connection;
        }

        public override bool SetWork(bool work)
        {
            return Work = work;
        }
    }
}
