using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.RS.Complex
{
    public class YearDateValidator : IConcreteDateValidator, IDateValidator
    {
        public bool DateValidate(int datePartNumber)
        {
            return datePartNumber >= 0;
        }

        public bool DateValidate(int year, int month, int day)
        {
            return DateValidate(year);
        }

        public string GetName()
        {
            return "Roman Suska";
        }
    }
}
