using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.Robson.OMR.VehicleComponents
{
    public class Rim : IDescriptionable, IUpdateable
    {
        protected float Size { get; private set; }
        protected string Category { get; private set; }
        protected string Description { get; set; }
        public string MadeBy { get; private set; }

        public Rim(float size, string category, string manufacturer)
        {
            Size = size;
            Category = category;
            MadeBy = manufacturer;
        }
        public string GetSpecification()
        {
            return string.Format("Rim specification:\n" +
                "Size: {0},\nCategory: {1},\nDescription: {2}\n", Size, Category, Description);
        }

        public string GetProducer()
        {
            return string.Format("Info about the manufacturer:\nThe rim was made by: {0}", MadeBy);
        }

        public void SetDescription(string description)
        {
            Description = description;
        }
    }
}
