using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.Robson.OMR.VehicleComponents
{
    public class Transmission : IDescriptionable, IUpdateable
    {
        protected TransmissionType Type { get; private set; }
        protected int GearsNumber { get; private set; }
        public Dictionary<int, int> MaxSpeedOnGear { get; private set; }
        public int CurrentGear { get; private set; }
        protected string Description { get; set; }
        protected string MadeBy { get; private set; }

        private int CurrentSpeed;

        public Transmission(TransmissionType type, int gears, int maxSpeed, string manufacturer)
        {
            MaxSpeedOnGear = new Dictionary<int, int>();
            Type = type;
            GearsNumber = gears;
            
            for(int i = 0; i <= gears; i++)
            {
                int topSpeedOnGear = (int)(((i) / (float)gears) * maxSpeed);
                MaxSpeedOnGear.Add(i, topSpeedOnGear);
            }
            MadeBy = manufacturer;
        }

        public void GearUP()
        {
            if(CurrentGear < GearsNumber)
            {
                CurrentGear++;
            }
        }

        public void GearDown()
        {
            if (CurrentGear > 0)
            {
                CurrentGear--;
            }
        }
        public int GetCurrentSpeed()
        {
            return this.CurrentSpeed;
        }
        public int GetRPMToSpeed(int maxRPM, int wantedSpeed)
        {
            int finalRPM = 0;
            if(wantedSpeed > MaxSpeedOnGear[CurrentGear])
            {
                finalRPM = maxRPM;
                CurrentSpeed = MaxSpeedOnGear[CurrentGear];
            }
            else if(wantedSpeed <= 0)
            {
                finalRPM = 0;
                CurrentSpeed = 0;
            }
            else
            {
                finalRPM = (int)((maxRPM * wantedSpeed) / MaxSpeedOnGear[CurrentGear]);
                CurrentSpeed = wantedSpeed;
            }
            
             return finalRPM;
        }
        public string GetSpecification()
        {
            StringBuilder gearRange = new StringBuilder();
            foreach(var gear in MaxSpeedOnGear)
            {
                gearRange.Append(gear.Key.ToString() + "===>" + gear.Value.ToString() + "\n");
            }

            return string.Format("Transmission specification:\n" +
                "Transmission type: {0},\nNumber of gears: {1},\n"+
                "Top speed on selected gear:\n" + gearRange.ToString() + 
                "Description: {2},\n", Type, GearsNumber, Description                
            );
        }

        public string GetProducer()
        {
            return string.Format("Info about the manufacturer:\nThe transmission was made by: {0}", MadeBy);
        }

        public void SetDescription(string description)
        {
            Description = description;
        }
    }
}
