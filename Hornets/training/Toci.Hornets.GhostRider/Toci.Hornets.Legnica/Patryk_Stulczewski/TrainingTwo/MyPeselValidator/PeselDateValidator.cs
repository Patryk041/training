using System;
using Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.Interfaces;

namespace Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.MyPeselValidator
{
    public class PeselDateValidator : IDateValidator
    {
        public bool ValidateDate(int year, int month, int day)
        {
            try{
                int preciseYear = new YearByPeselMonthGenerator().GetYear(month) + year;
                if (DaysInMonthValidator.IsCorrectCountOfDays(year, month % 20, day))
                    return !IsDateInFuture(preciseYear, month % 20, day);
            }
            catch
            {
                // ignored
            }
            return false;
        }

        private bool IsDateInFuture(int year, int month, int day)
        {
            DateTime dt = new DateTime(year, month, day);
            return dt > DateTime.Now;
        }

    }
}