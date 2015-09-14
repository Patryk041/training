using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricTraining
{
    public interface IBike
    {
        bool Ride();

        int WheelSize { get; set; }
        int FrameSize { get; set; }
        string Description { get; set; }

        

    }
}
