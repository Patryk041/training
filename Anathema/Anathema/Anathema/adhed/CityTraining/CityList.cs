using System.Collections.Generic;
using System.Linq;
using Anathema.adhed.Generics;

namespace Anathema.adhed.CityTraining
{
    public class CityList : GenericList<City>
    {
        public CityList()
        {
            _list = new List<City>();
        }

        public bool CityExistsInList(string cityName)
        {
            //LINQ: check that any element with the same city name exists in the list
            return _list.Any(city => city.CityName == cityName);
        }
       
    }
}