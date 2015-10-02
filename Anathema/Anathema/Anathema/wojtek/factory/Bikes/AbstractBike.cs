using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.wojtek.factory.Bikes
{
    public abstract class AbstractBike : IBike
    {
        public string Colour { get; set; }
        public int FrameSize { get; set; }
        public int WheelSize { get; set; }
        public string Destination { get; set; }
        public string Name { get; set; }

        public virtual bool Ride(string destination)
        {
            if (this.Destination == destination)
                return true;
            return false;
        }
    }
}
