using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.OMR;
using Toci.TraininigLibrary.Developers.Robson.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.Robson.OMR.VehicleComponents
{
    public class Engine : IDescriptionable
    {
        protected EngineType Type { get; private set; }
        protected string ConstructionType { get; private set; }
        protected int CylinderNumber { get; private set; }
        protected string MadeBy { get; private set; }
        protected float Capacity { get; private set; }
        protected int Power { get; private set; }
        public int CurrentRPM { get; set; }
        protected int MaxRPM { get; private set; }
        protected bool IsOn { get; private set; }

        public Engine(EngineType type, string construction, int cylinders, string manufacturer, float capacity, int horsepower, int rpm)
        {
            Type = type;
            ConstructionType = construction;
            CylinderNumber = cylinders;
            MadeBy = manufacturer;
            Capacity = capacity;
            Power = horsepower;
            MaxRPM = rpm;
        }

        public void RpmUp(int value)
        {
            CurrentRPM += value;
        }

        public void RpmDown(int value)
        {
            CurrentRPM -= value;
        }
        public int GetMaxRPM()
        {
            return MaxRPM;
        }

        public void StartEngine()
        {
            IsOn = true;
        }
        public void StopEngine()
        {
            IsOn = false;
        }
        public string GetSpecification()
        {
            return string.Format("Engine specification:\n" +
                "Engine type: {0}, {1},\nNumber of cylinders: {2},\nCapacity: {3},\nPower: {4},\nRoundsPerMinute (max.): {5}\n", Type.ToString(), ConstructionType, 
                CylinderNumber, Capacity, Power, MaxRPM);
        }

        public string GetProducer()
        {
            return string.Format("Info about the manufacturer:\nThe engine was made by: {0}", MadeBy);
        }
    }
}
