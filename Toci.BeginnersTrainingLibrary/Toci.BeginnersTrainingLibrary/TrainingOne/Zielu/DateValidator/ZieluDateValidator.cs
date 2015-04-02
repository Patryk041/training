using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.DateValidator
{
    public class ZieluDateValidator : IDateValidator
    {
        public bool CheckDate(int year, int month, int day)
        {
            var whatDay = new ZieluDayValidator();
            return whatDay.Validate(day, month, year);
        }

        public string GetNick()
        {
            return "Zielu";
        }
    }
}
