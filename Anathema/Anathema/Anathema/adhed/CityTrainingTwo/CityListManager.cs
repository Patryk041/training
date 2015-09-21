using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using Anathema.adhed.CityTraining.Parsers;
using Anathema.adhed.CityTrainingTwo.Generics;
using Anathema.adhed.CityTrainingTwo.Parsers;

namespace Anathema.adhed.CityTrainingTwo
{
    public class CityListManager : GenericListManager<City>
    {

        public override bool CheckElementExists(string value)
        {
             return GList.Any(item => item.CityName == value);
        }

        public override void LoadElements(string path)
        {
            var parser = new TxtFileCitiesParser();
            List<City> cities = parser.GetAllResults(path);
            JoinList(cities);
        }

        public List<City> GetCitiesStartsWithLetter(string letter)
        {
            return GList.Where(item => item.CityName.StartsWith(letter)).ToList();
        }

        public override void RemoveElement(string cityName)
        {
            GList.RemoveAll(city => city.CityName == cityName);
        }

        public override int CountElementsStartWithLetter(string letter)
        {
            return GList.Count(city => city.CityName.StartsWith(letter));
        }

    }
}