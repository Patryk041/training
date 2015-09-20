using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Anathema.adhed.CityTraining.Parsers;
using Anathema.adhed.CityTrainingTwo.Parsers;

namespace Anathema.adhed.CityTrainingTwo
{
    public class CityListManager
    {
        private List<City> _cityList;

        public CityListManager()
        {
            _cityList = new List<City>();
        }

        public List<City> GetCitiesList()
        {
            return _cityList;
        }

        public void AddCity(City city)
        {
            _cityList.Add(city);
        }

        public bool CheckCityExists(string cityName)
        {
            return _cityList.Any(item => item.CityName == cityName);
        }

        public void JoinList(List<City> listToJoin)
        {
            foreach (var city in listToJoin)
            {
                _cityList.Add(city);
            }
        }

        public void LoadCities(string path)
        {
            TxtFileCitiesParser parser = new TxtFileCitiesParser();
            List<City> cities = parser.GetAllResults(path);   
            JoinList(cities);
        }
    }
}