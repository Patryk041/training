using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.Robson.OMR.VehicleComponents
{
    public class Body : IDescriptionable, IUpdateable
    {
        protected BodyType Type { get; private set; }
        protected string Description { get; set; }
        protected string MadeBy { get; private set; }

        public Body(BodyType type, string manufacturer)
        {
            Type = type;
            MadeBy = manufacturer;
        }
        public string GetSpecification()
        {
            return string.Format("Carbody specification:\n" +
                "Body type: {0},\nDescription: {1}\n", Type, Description);
        }

        public string GetProducer()
        {
            return string.Format("Info about the manufacturer:\nThe body was made by: {0}", MadeBy);
        }

        public void SetDescription(string description)
        {
            Description = description;
        }
    }
}
