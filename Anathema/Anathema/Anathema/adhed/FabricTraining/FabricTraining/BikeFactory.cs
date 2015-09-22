using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricTraining.Bikes;

namespace FabricTraining
{
    class BikeFactory
    {
        private Dictionary<string, Func<IBike>> _dictionary;

        public BikeFactory()
        {
            _dictionary = new Dictionary<string, Func<IBike>>()
            {
                {"Enduro", () => new Enduro()},
                {"RoadBike", () => new RoadBike()},
                {"HardtailXc", () => new HardtailXc()}          
            };
        }

        public IBike GetBike(string bikeName)
        {
            return _dictionary[bikeName]();
        }
    }
}
