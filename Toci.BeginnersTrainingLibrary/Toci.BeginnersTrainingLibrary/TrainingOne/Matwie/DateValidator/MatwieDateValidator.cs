using System;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.DateValidator
{
    public class MatwieDateValidator : IDateValidator
    {
        private delegate bool CheckDateDelegate(int year, int month, int day);

        public bool CheckDate(int year, int month, int day)
        {
            CheckDateDelegate checkDateDelegate = YearValidator.IsValid;
            checkDateDelegate += MonthValidator.IsValid;
            checkDateDelegate += DayValidator.IsValid;

            try
            {
                checkDateDelegate(year, month, day);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public string GetNick()
        {
            return "matwie";
        }
    }
}
