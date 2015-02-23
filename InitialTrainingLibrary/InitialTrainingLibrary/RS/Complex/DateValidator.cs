using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.RS.Complex
{
    public class DateValidator : IDateValidator
    {
        private readonly IConcreteDateValidator _yearDateValidator;
        private readonly IConcreteDateValidator _monthDateValidator;
        private readonly IDateValidator _dayValidator;

        public DateValidator()
        {
            _yearDateValidator = new YearDateValidator();
            _monthDateValidator = new MonthDateValidator();
            _dayValidator = new DayValidator();
        }

        public bool DateValidate(int year, int month, int day)
        {
            return _yearDateValidator.DateValidate(year) && _monthDateValidator.DateValidate(month) &&
                   _dayValidator.DateValidate(year, month, day);
        }

        public string GetName()
        {
            return "Roman Suska cmp";
        }
    }
}
