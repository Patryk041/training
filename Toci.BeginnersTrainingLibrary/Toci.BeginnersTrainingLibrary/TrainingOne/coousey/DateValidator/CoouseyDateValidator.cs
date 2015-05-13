
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.coousey.DateValidator
{
    public class CoouseyDateValidator : IDateValidator
    {
        private delegate void ValidationDelegate(Date date);

        public bool CheckDate(int year, int month, int day)
        {
            Date date = new Date(year, month, day);

            ValidationDelegate validationDelegate = new ValidationDelegate(new YearValidator().Validate)
            + new MonthValidator().Validate
            + new DayValidator().Validate;

            validationDelegate(date);

            return date.IsValid();
        }

        public string GetNick()
        {
            return "Coousey";
        }
    }
}
