using System.Collections.Generic;
using Anathema.adhed.Generics;

namespace Anathema.adhed.CityTraining
{
    public class CityList : GenericList<City>
    {
        public CityList()
        {
            _list = new List<City>();
        }
       
    }
}