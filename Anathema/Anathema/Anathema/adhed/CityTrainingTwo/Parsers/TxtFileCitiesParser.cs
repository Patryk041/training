using Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract;

namespace Anathema.adhed.CityTrainingTwo.Parsers
{
    public class TxtFileCitiesParser : TxtParser<City>
    {
        protected override City GetResult(string entry)
        {
            return new City(entry);
        }
    }
}