using Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract;

namespace Anathema.adhed.CityTrainingTwo.Parsers
{
    public class TxtFileCitiesParser : TxtParser<City>
    {
        protected override City GetResult(string entry)
        {
            var list = entry.Split('\r');
            return new City(list[0]);
        }
    }
}