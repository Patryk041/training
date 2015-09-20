using System.Collections.Generic;

namespace Anathema.adhed.CityTraining
{
    public class CityManager
    {
        private List<City> _citiesList;

        public CityManager()
        {
            _citiesList = new List<City>();
        }

        public void AddCityToList(City city)
        {
            _citiesList.Add(city);
        }

        public List<City> GetCities()
        {
            return _citiesList;
        } 
    }
}