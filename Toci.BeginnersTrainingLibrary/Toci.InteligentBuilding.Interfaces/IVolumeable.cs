using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.InteligentBuilding.Interfaces
{
    public interface IVolumeable
    {
        double Height { get; set; }

        double Width { get; set; }

        double Length { get; set; }

        double GetSurface();

        double GetVolume(); //nie chodzi o knajpe, width * height * length
    }
}
