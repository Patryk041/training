using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.OMR.BaseClasses;
using Toci.TraininigLibrary.Developers.Robson.OMR.CarComponents;
using Toci.TraininigLibrary.Developers.Robson.OMR.VehicleComponents;

namespace Toci.TraininigLibrary.Developers.Robson.OMR.ChildClasses
{
    public class Car : Vehicle
    {
        protected Radio Radio;
        protected Airconditioner Airconditioner;

        public Car(Radio radio, Airconditioner airconditioner, Body body, Engine engine, List<Light> lights, List<Wheel> wheels, Transmission transmission)
        {
            Radio = radio;
            Airconditioner = airconditioner;

            base.Body = body;
            base.Engine = engine;
            base.Lights = lights;
            base.Wheels = wheels;
            base.Transmission = transmission;
        }
        public override void SpeedUP(int value)
        {
            int wantedSpeed = base.Transmission.GetCurrentSpeed() + value;
            
            while(base.Transmission.GetCurrentSpeed() < wantedSpeed)
            {
                if(base.Transmission.MaxSpeedOnGear[base.Transmission.CurrentGear] < wantedSpeed)
                {
                    //  Tu można jeszcze dodać metodę, która będzie podczas zmiany biegów operowała obrotami silnika.

                    base.Transmission.GearUP();
                    
                    //  Należy sprawdzić, czy nie mamy już ostatniego biegu wbitego.
                    if(base.Transmission.CurrentGear == base.Transmission.MaxSpeedOnGear.Count - 1)
                    {
                        base.Engine.CurrentRPM = base.Transmission.GetRPMToSpeed(base.Engine.GetMaxRPM(), wantedSpeed);
                        return;
                    }                   
                }
                else
                {
                    //  logika odpowiedzialna za dostosowanie obrotów silnika już na docelowym biegu.
                    base.Engine.CurrentRPM = base.Transmission.GetRPMToSpeed(base.Engine.GetMaxRPM(), wantedSpeed);
                    return;
                }
            }
        }

        public override void SlowDown(int value)
        {
            int wantedSpeed = base.Transmission.GetCurrentSpeed() - value;

            while (base.Transmission.GetCurrentSpeed() > wantedSpeed)
            {
                if (base.Transmission.MaxSpeedOnGear[base.Transmission.CurrentGear] <= wantedSpeed)
                {
                    base.Transmission.GearUP();
                    //  logika odpowiedzialna za dostosowanie obrotów silnika już na docelowym biegu.
                    base.Engine.CurrentRPM = base.Transmission.GetRPMToSpeed(base.Engine.GetMaxRPM(), wantedSpeed);
                    return;
                }
                else
                {
                    //  Tu można jeszcze dodać metodę, która będzie podczas zmiany biegów operowała obrotami silnika.
                    base.Transmission.GearDown();

                    //  Należy sprawdzić, czy już się nie zatrzymałem.
                    if (base.Transmission.CurrentGear == 0)
                    {
                        base.Transmission.GetRPMToSpeed(base.Engine.GetMaxRPM(), wantedSpeed);
                        return;
                    }
                }
            }
        }

        public override void StartEngine()
        {
            base.Engine.StartEngine();
        }

        public override void StopEngine()
        {
            base.Engine.StopEngine();
        }
        public override string GetVehicleState()
        {
            StringBuilder technicalData = new StringBuilder();

            technicalData.Append("Current RPM: " + base.Engine.CurrentRPM + "\n");
            technicalData.Append("Current speed: " + base.Transmission.GetCurrentSpeed() + "\n");
            technicalData.Append("Current gear: " + base.Transmission.CurrentGear + "\n");

            return technicalData.ToString();
        }

        public override void TurnLightsOn(bool state)
        {
            foreach(var item in base.Lights)
            {
                item.TurnedOn = true;
            }
        }

        public override void TurnLightsOff(bool state)
        {
            foreach (var item in base.Lights)
            {
                item.TurnedOn = false;
            }
        }


        public override int GetCurrentSpeed()
        {
            return base.Transmission.GetCurrentSpeed();
        }

        public override int GetCurrentGear()
        {
            return base.Transmission.CurrentGear;
        }

        public override int GetCurrentRPM()
        {
            return base.Engine.CurrentRPM;
        }
    }
}
