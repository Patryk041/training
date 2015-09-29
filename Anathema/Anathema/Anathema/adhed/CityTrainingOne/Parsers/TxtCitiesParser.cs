using System;
using Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract;

namespace Anathema.adhed.CityTraining.Parsers
{
    public class TxtCitiesParser : TxtParser<City> 
    {
        protected override City GetResult(string entry)
        {
            return new City(entry);
        }
    }
}