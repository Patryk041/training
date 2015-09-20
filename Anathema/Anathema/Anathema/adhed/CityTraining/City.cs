using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.adhed.CityTraining
{
    public class City
    {
        public string CityName { get; set; }
        public int SurfaceArea { get; set; }
        public int Population { get; set; }

        public City(string name)
        {
            CityName = name;
        }
    }
}
