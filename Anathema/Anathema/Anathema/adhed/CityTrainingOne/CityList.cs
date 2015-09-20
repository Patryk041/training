using System.Collections.Generic;
using System.Linq;
using Anathema.adhed.Generics;

namespace Anathema.adhed.CityTraining
{
    public class CityList : GenericList<City>
    {

        /* BULLSHIT!
         * BULLSHIT!
         * BULLSHIT!
         */

        public CityList()
        {
            List = new List<City>();
        }

        public bool CheckCityExistsInList(string cityName)
        {
            //LINQ: check that any element with the same city name exists in the list
            return List.Any(city => city.CityName == cityName);
        }
       
    }
}