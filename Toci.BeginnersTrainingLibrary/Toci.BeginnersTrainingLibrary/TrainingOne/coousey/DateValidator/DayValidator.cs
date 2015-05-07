
namespace Toci.BeginnersTrainingLibrary.TrainingOne.coousey.DateValidator
{
    class DayValidator : IValidator
    {
        private const int LongFebruaryDays = 29;
        private const int ShortFebruaryDays = 28;
        private const int LeapMonth = 2;
        private const int ShortMonthDays = 30;

        public void Validate(Date date)
        {
            bool leapYear = ((date.Year % 4 == 0) && (date.Year % 100 != 0)) || (date.Year % 400 == 0);

            if (((date.Month == 4) || (date.Month == 6) || (date.Month == 9) || (date.Month == 11)) && (date.Day > ShortMonthDays)) date.DayIsValid = false;
            else if ((date.Month == LeapMonth) && leapYear && (date.Day > LongFebruaryDays)) date.DayIsValid = false;
            else if ((date.Month == LeapMonth) && !leapYear && (date.Day > ShortFebruaryDays)) date.DayIsValid = false;
        }
    }
}
