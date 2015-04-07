using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.Robson.OMR.CarComponents
{
     public class Airconditioner : IDescriptionable, IUpdateable
    {
         protected float MaxTemp { get; private set; }
         protected float MinTemp { get; private set; }
         protected bool Climatronic { get; private set; }
         protected string MadeBy { get; private set; }
         protected string Description { get; private set; }
         public float CurrentTemp 
         { 
             get
             {
                 return this.CurrentTemp;
             }
             set
             {
                 if (value > MaxTemp)
                     this.CurrentTemp = MaxTemp;
                 else if (value < MinTemp)
                     this.CurrentTemp = MinTemp;
                 else
                     this.CurrentTemp = value;
             }
         }
         public bool FanOn { get; set; }
         public bool ConditionerOn { get; set; }
         public WorkingArea FanDirection { get; set; }

         public Airconditioner(float maxTemp, float minTemp, bool hasClimatronic, string manufacturer)
         {
             MaxTemp = maxTemp;
             MinTemp = minTemp;
             Climatronic = hasClimatronic;
             MadeBy = manufacturer;
         }
        public void SetDescription(string description)
        {
            Description = description;
        }

        public string GetSpecification()
        {
            string climatronic = Climatronic ? "Steering: Climatronic\n" : ("Steering: manual\n");
            return string.Format("Airconditioner specification:\n" + climatronic +
                "Max. temperature: {0},\tMin. temperature: {1},\nDescription: {2}", MaxTemp, MinTemp, Description);
        }

        public string GetProducer()
        {
            return string.Format("Info about the manufacturer:\nThe airconditioner was made by: {0}", MadeBy);
        }
    }
}
