using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.wojtek.factory.Bikes
{
    public class Specialized : AbstractBike
    {
        public Specialized()
        {
            Name = "Specialized";
        }

        public override bool Ride(string destination)
        {
            return true; //can ride everywhere
        }
    }
}
