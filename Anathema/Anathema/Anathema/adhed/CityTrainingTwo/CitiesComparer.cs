using System.Collections;
using System.Collections.Generic;

namespace Anathema.adhed.CityTrainingTwo
{
    public class CitiesComparer : IEqualityComparer<City> 
    {
        public bool Equals(City x, City y)
        {
            return Equals(x.CityName, y.CityName);
        }

        public int GetHashCode(City obj)
        {
            return obj.CityName.GetHashCode();
        }
    }
}