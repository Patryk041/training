using System;
using Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract;

namespace Anathema.adhed.CityTrainingTwo.Parsers
{
    public class TxtFileCitiesParser : TxtParser<City>
    {
        protected override City GetResult(string entry)
        {
            var list = entry.Split(Environment.NewLine.ToCharArray());

            return list[0] == "" ? null : new City(list[0]);
        }
    }
}