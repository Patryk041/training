using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
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
            var parser = new TxtFileCitiesParser();
            List<City> cities = parser.GetAllResults(path);   
            JoinList(cities);
        }

        public List<City> GetCitiesStartsWithLetter(string letter)
        {
            return _cityList.Where(item => item.CityName.StartsWith(letter)).ToList();
        }

        public void RemoveCity(string cityName)
        {
            _cityList.RemoveAll(city => city.CityName == cityName);
        }

        public int CountCitiesStartsWithLetter(string letter)
        {
            return _cityList.Count(city => city.CityName.StartsWith(letter));
        }

        public int CountCities()
        {
            return _cityList.Count();
        }

        public void RemoveDuplicates()
        {
           _cityList = _cityList.Distinct(new CitiesComparer()).ToList();
        }
    }
}