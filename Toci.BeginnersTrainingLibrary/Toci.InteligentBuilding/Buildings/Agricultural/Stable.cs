using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.InteligentBuilding.Abstraction.Buildings;
using Toci.InteligentBuilding.Abstraction.Buildings.Agricultural;
using Toci.InteligentBuilding.Interfaces.Building;

namespace Toci.InteligentBuilding.Buildings.Agricultural
{
    public class Stable : AgriculturalBuilding, IMultiStoreyBuilding
    {
        private static readonly double MinimumSpacePerAnimal = 5; //

        public Stable()
        {
            MinimumSurfacePerAnimal = MinimumSpacePerAnimal;
        }

        public override string GetName()
        {
            return BuildingsNames.StableName;
        }

        
    }
}
