using System.Collections.Generic;

namespace Toci.Hornets.Kalisz.Amman.PeselValidator.Workers.DateValidation
{
    public class DayValidator
    {
        public static int GetDay(string date)
        {
            var day = int.Parse(date.Substring(4, 2));
            return day;
        }
        public static bool IsValid(int day,int month,int year)
        {
            //try parse for letters?
            if (!MonthValidator.IsValid(month)) return false;
            if (day < 1 || day > 31 ) return false;

            var dayMonthDictionary = new Dictionary<int, int>()
            {
                {1, 31},
                {2, 27},
                {3, 31},
                {4, 30},
                {5, 31},
                {6, 30},
                {7, 31},
                {8, 31},
                {9, 30},
                {10, 31},
                {11, 30},
                {12, 31}
            };
            if (YearValidator.IsLeap(year)) dayMonthDictionary[2] = 28;
            return day <= dayMonthDictionary[month];
        }
    }
    }
