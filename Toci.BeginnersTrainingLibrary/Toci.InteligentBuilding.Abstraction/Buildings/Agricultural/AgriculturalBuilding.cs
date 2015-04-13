using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.InteligentBuilding.Interfaces.Building;

namespace Toci.InteligentBuilding.Abstraction.Buildings.Agricultural
{
    public abstract class AgriculturalBuilding : Building, IAgriculturalBuilding
    {
        protected double MinimumSurfacePerAnimal;

        public int GetStoreyCount()
        {
            throw new NotImplementedException();
        }

        public int AnimalCapacity() //animal capacity
        {
            return (int)Math.Floor((decimal)(GetSurface() / MinimumSurfacePerAnimal)); // 5,5 5,8 5,9 => 5
        }
    }
}
