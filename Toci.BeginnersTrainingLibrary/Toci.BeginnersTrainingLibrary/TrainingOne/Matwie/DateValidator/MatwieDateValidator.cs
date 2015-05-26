using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.DateValidator
{
    public class MatwieDateValidator : IDateValidator
    {
        public bool CheckDate(int year, int month, int day)
        {
            return YearValidator.IsValid(year, month, day) && MonthValidator.IsValid(year, month, day)
                && DayValidator.IsValid(year, month, day);
        }

        public string GetNick()
        {
            return "matwie";
        }
    }
}
