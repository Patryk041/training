using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.wojtek.factory
{
    public interface IBike
    {
        string Colour { get; set; }
        int FrameSize { get; set; }
        int WheelSize { get; set; }
        string Destination { get; set; }

        bool Ride(string destination);
        
    }
}
