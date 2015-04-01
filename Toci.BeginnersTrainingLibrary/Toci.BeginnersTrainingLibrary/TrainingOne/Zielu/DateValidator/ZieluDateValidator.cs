using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.DateValidator
{
    public class ZieluDateValidator : IDateValidator
    {
        public bool CheckDate(int year, int month, int day)
        {
            var dzien = new ZieluDayValidator();
            var miesiac = new ZieluMonthValidator();
            return dzien.Validate(day, month, year) && miesiac.Validate(month);
        }

        public string GetNick()
        {
            return "Zielu";
        }
    }
}
