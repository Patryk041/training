using Anathema.wojtek.factory.Bikes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.wojtek.factory
{
    public class BikeFactory : AbstractFactory<string, IBike>
    {
        public BikeFactory()
        {
            AbstFactDict = new Dictionary<string, Func<IBike>>()
            {
                {"Specialized",() => new Specialized()},
                {"Giant",() => new Giant()},
                {"Canyon",()=>new Canyon()}
            };
        }
    }
}
