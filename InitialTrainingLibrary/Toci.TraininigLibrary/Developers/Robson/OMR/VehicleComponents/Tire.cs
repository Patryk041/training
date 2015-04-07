using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.Robson.OMR.VehicleComponents
{
    public class Tire : IDescriptionable, IUpdateable
    {
        protected float Size { get; private set; }
        protected float Age { get; private set; }
        protected string Description { get; set; }
        public string MadeBy { get; private set; }

        public Tire(float size, float age, string manufacturer)
        {
            Size = size;
            Age = age;
            MadeBy = manufacturer;
        }

        public string GetSpecification()
        {
            return string.Format("Tire specification:\n" +
                "Size: {0},\tAge: {1},\nDescription: {2}\n", Size, Age, Description);
        }

        public string GetProducer()
        {
            return string.Format("Info about the manufacturer:\nThe tire was made by: {0}", MadeBy);
        }

        public void SetDescription(string description)
        {
            Description = description;
        }
    }
}
