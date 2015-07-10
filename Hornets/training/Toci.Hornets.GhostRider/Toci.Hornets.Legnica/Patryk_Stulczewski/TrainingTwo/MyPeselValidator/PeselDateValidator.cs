using System;
using Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.Interfaces;

namespace Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.MyPeselValidator
{
    public class PeselDateValidator : IDateValidator
    {
        public bool ValidateDate(int year, int month, int day)
        {
            try{
                int preciseYear = GenerateYearByMonth(month) + year;
                if (IsCorrectDate(preciseYear, month % 20, day))
                    return !IsDateInFuture(preciseYear, month % 20, day);
            }
            catch (Exception ex)
            {
                // ignored
            }
            return false;
        }

        private bool IsCorrectDate(int year, int month, int day)
        {
            return DaysInMonthValidator.IsCorrectCountOfDays(year, month, day);
        }

        private bool IsDateInFuture(int year, int month, int day)
        {
            DateTime dt = new DateTime(year, month, day);
            return dt > DateTime.Now;
        }

        private int GenerateYearByMonth(int month)
        {
            return YearByPeselMonthGenerator.GetYear(month);
        }
    }
}