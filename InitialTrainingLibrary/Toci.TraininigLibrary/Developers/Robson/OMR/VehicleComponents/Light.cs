using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.Robson.OMR.VehicleComponents
{
    public class Light : IDescriptionable, IUpdateable
    {
        public bool TurnedOn { get; set; }
        protected int Brightness { get; private set; }
        protected string Description { get; set; }
        protected string MadeBy { get; private set; }

        public Light(int brightness, string manufacturer)
        {
            Brightness = brightness;
            MadeBy = manufacturer;
        }
        public string GetSpecification()
        {
            return string.Format("Light specification:\nBrightness: {0},\nDescription: {1}\n");
        }

        public string GetProducer()
        {
            return string.Format("Info about the manufacturer:\nThe light was made by: {0}", MadeBy);
        }

        public void SetDescription(string description)
        {
            Description = description;
        }
    }
}
