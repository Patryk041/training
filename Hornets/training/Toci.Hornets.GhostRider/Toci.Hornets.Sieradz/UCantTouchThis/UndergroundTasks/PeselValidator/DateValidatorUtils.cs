using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.PeselValidator
{
    public static class DateValidatorUtils
    {
        private const int MinYear = 1800;
        private const int MonthLowerBoundary = 0;
        private const int MonthUpperBoundary = 13;

        private static Dictionary<int[], Func<int,int>> _dayMap = new Dictionary<int[], Func<int, int>>()
        {
            {new []{1,3,5,7,8,10,12}, year => 31},
            {new []{4,6,9,11}, year => 30},
            {new []{2}, year => (IsYearLeap(year) ? 29 : 28)}
        };

        static bool IsYearLeap(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        //not needed in pesel validation
        static bool IsYearValid(int year)
        {
            return year > MinYear;
        }

        static bool IsMonthValid(int month)
        {
            return month > MonthLowerBoundary && month < MonthUpperBoundary;
        }

        static bool IsDayValid(int day, int month, int year)
        {
            if (day == 0) return false;
            var key = _dayMap.Keys.FirstOrDefault(x => x.Contains(month));
            return day <= _dayMap[key].Invoke(year);
        }

        public static bool IsDateValid(int day, int month, int year)
        {
            DateTime date;
            return DateTime.TryParse(month + "/" + day + "/" + year, CultureInfo.CreateSpecificCulture("en-US"), DateTimeStyles.None, out date);
//            return DateTime.TryParse(month + "/" + day + "/" + year, out date);
        }

        public static bool IsDateValidAndAutistic(int day, int month, int year)
        {
            return IsMonthValid(month) && IsDayValid(day, month, year);
        }
    }
}