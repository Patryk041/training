using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.OMR.VehicleComponents;

namespace Toci.TraininigLibrary.Developers.Robson.OMR.BaseClasses
{
    public abstract class Vehicle
    {
        protected Body Body { get; set; }
        protected Engine Engine { get; set; }
        protected Transmission Transmission { get; set; }
        protected List<Wheel> Wheels { get; set; }
        protected List<Light> Lights { get; set; }

        public abstract void SpeedUP(int value);
        public abstract void SlowDown(int value);
        public abstract void StartEngine();
        public abstract void StopEngine();
        public abstract void TurnLightsOn(bool state);
        public abstract void TurnLightsOff(bool state);
        public abstract int GetCurrentSpeed();
        public abstract int GetCurrentGear();
        public abstract int GetCurrentRPM();
        public abstract string GetVehicleState();
    }
}
