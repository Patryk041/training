using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.InteligentBuilding.Interfaces.Building
{
    public interface IAgriculturalBuilding : IBuilding
    {
        int AnimalCapacity();
    }
}
