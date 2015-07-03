using System;
using System.Collections.Generic;
using System.Linq;

namespace Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.PeselValidator
{
    public static class DateValidatorUtils
    {
        private const int MinYear = 1800;
        private const int MonthLowerBoundary = 0;
        private const int MonthUpperBoundary = 13;

        private static Dictionary<int[], Func<int,int,int>> _dayMap = new Dictionary<int[], Func<int, int, int>>()
        {
            {new []{1,3,5,7,8,10,12}, (month, year) => 31},
            {new []{4,6,9,11}, (month, year) => 30},
            {new []{2}, (month, year) => IsYearLeap(year) ? 29 : 28}
        };

        static bool IsYearLeap(int year)
        {
            if (year % 4 != 0) return false;
            if (year%100 != 0) return true;
            if (year%400 != 0) return false;
            return true;
        }

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
            var key = _dayMap.Where(x => x.Key.Contains(day)).Select(x => x.Value).FirstOrDefault();
            return day == key.Invoke(month, year);
        }

        static bool IsDateValid(int day, int month, int year)
        {
            DateTime date;
            return DateTime.TryParse(month + "/" + day + "/" + year, out date);
        }
    }
}