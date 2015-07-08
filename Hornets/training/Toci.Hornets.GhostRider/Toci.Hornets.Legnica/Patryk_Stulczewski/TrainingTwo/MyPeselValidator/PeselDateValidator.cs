using System;
using Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.Interfaces;

namespace Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.MyPeselValidator
{
    public class PeselDateValidator : IDateValidator
    {
        public bool ValidateDate(int year, int month, int day)
        {
            if (IsCorrectDate(year, month, day))
                return !IsDateInFuture(year, month, day);
            return false;
        }

        private bool IsCorrectDate(int year, int month, int day)
        {
            int yearByMonth = GenerateYearByMonth(month);
            return DaysInMonthValidator.IsCorrectCountOfDays(year + yearByMonth, month % 20, day);
        }

        private bool IsDateInFuture(int year, int month, int day)
        {
            int yearByMonth = GenerateYearByMonth(month);
            DateTime dt = new DateTime(year + yearByMonth, month % 20, day);
            return dt > DateTime.Now;
        }

        private int GenerateYearByMonth(int month)
        {
            return YearByPeselMonthGenerator.GetYear(month);
        }
    }
}