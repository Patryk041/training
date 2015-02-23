using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.RS.Complex
{
    public class MonthDateValidator : IConcreteDateValidator, IDateValidator
    {
        public bool DateValidate(int datePartNumber)
        {
            return datePartNumber > 0 && datePartNumber < 13;
        }

        public bool DateValidate(int year, int month, int day)
        {
            return DateValidate(month);
        }

        public string GetName()
        {
            return "Roman Suska";
        }
    }
}
