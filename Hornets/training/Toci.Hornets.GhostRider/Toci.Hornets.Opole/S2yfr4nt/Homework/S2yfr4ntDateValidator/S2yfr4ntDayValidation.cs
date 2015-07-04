using System.Collections.Generic;

namespace Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntDateValidator
{
    public class S2yfr4ntDayValidation
    {
        private const int february = 2;
        private const int minDayLimit = 1;
        private static int _month;
        private static int _year;

        private static Dictionary<int, int> monthDay = new Dictionary<int, int>()
        {
            { 1, 31 },
            { 3, 31 },
            { 4, 30 },
            { 5, 31 },
            { 6, 30 },
            { 7, 31 },
            { 8, 31 },
            { 9, 30 },
            { 10, 31 },
            { 11, 30 },
            { 12, 31 },
        };

        private static int MaxDayLimit()
        {
            if (_month == february)
                return (S2yfr4ntYearValidation.isLeapYear(_year) ? 29 : 28);

            if (monthDay.ContainsKey(_month))
                return monthDay[_month];

            return 0;
        }


        public static bool ValidateDay(int year, int month, int day)
        {
            _month = month;
            _year = year;

            return (day >= minDayLimit && day <= MaxDayLimit());
        } 
    }
}