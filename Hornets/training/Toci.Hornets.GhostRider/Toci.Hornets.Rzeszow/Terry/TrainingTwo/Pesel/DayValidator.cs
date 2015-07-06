using System.Collections.Generic;

namespace Toci.Hornets.Rzeszow.Terry.TrainingTwo.Pesel
{
    public static class DayValidator
    {
        private const int MinimumDays = 1;
        private const int ThirtyDayMonths = 30;
        private const int ThirtyOneDayMonths = 31;
        private const int FebruaryLeapYear = 29;
        private const int FebruaryNormalYear = 28;

        private static Dictionary<int, int> _monthList = new Dictionary<int, int>()
        {
            {1,ThirtyOneDayMonths},
            {2, FebruaryNormalYear},
            {3, ThirtyOneDayMonths},
            {4, ThirtyDayMonths},
            {5, ThirtyOneDayMonths},
            {6, ThirtyDayMonths},
            {7, ThirtyOneDayMonths},
            {8, ThirtyOneDayMonths},
            {9, ThirtyDayMonths},
            {10, ThirtyOneDayMonths},
            {10, ThirtyDayMonths},
            {12, ThirtyOneDayMonths},
        };
        private static bool IsNumberOfDaysValid(PeselDate date)
        {
            return (MinimumDays <= date.Day && date.Day <= ThirtyOneDayMonths);
        }

        public static bool ValidateDays(PeselDate date)
        {
            if (date.IsLeapYear)
            {
                _monthList[2] = FebruaryLeapYear;
            }
            var numberOfDaysInMonth = _monthList[date.Month-1];

            return IsNumberOfDaysValid(date) && (date.Day >= MinimumDays && date.Day <= numberOfDaysInMonth);
        }
        
    }
}
