using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.Robson.OMR.VehicleComponents
{
    public class Wheel : IDescriptionable
    {
        protected Tire Tire { get; private set; }
        protected Rim Rim { get; private set; }
        protected string MadeBy { get; private set; }
        public InstallationSite installationSite { get; set; }

        public Wheel(Tire tire, Rim rim)
        {
            Tire = tire;
            Rim = rim;
            MadeBy = tire.MadeBy + rim.MadeBy;
        }
        public string GetSpecification()
        {
            return string.Format(Tire.GetSpecification() + "\n" + Rim.GetSpecification());
        }

        public string GetProducer()
        {
            return string.Format("Info about the manufacturer:\nThe wheel's components comes from: {0}", MadeBy);
        }
    }
}
