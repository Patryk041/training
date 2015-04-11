using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.DateValidator
{
    public class ZieluDateValidator : IDateValidator
    {
        public bool CheckDate(int year, int month, int day)
        {
            ZieluDayValidator whatDay = new ZieluDayValidator();
            ZieluMonthValidator whatMonth = new ZieluMonthValidator();
            ZieluYearValidator whatYear = new ZieluYearValidator();
            return whatDay.Validate(day, month, year) && whatMonth.Validate(month) && whatYear.Validate(year);
        }

        public string GetNick()
        {
            return "Zielu";
        }
    }
}
