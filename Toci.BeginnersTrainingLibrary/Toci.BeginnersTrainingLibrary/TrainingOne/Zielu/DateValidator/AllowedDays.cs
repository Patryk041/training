using System;
using System.Collections.Generic;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.DateValidator
{
    public class AllowedDays
    {
        private const int MaxLongDays = 32;
        private const int MaxShortDays = 31;
        private const int MaxFebruaryDays = 29;
        private const int UnallowedDay = 0;

        private readonly Dictionary<int, int> _miesiace = new Dictionary<int, int>
        {
            {1, MaxLongDays},
            {2, MaxFebruaryDays},
            {3, MaxLongDays},
            {4, MaxShortDays},
            {5, MaxLongDays},
            {6, MaxShortDays},
            {7, MaxLongDays},
            {8, MaxLongDays},
            {9, MaxShortDays},
            {10, MaxLongDays},
            {11, MaxShortDays},
            {12, MaxLongDays}
        };

        private bool IsLeapYear(int year)
        {
            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
        }

        public int MaxAllowedDay(int year, int month)
        {
            try
            {
                if (IsLeapYear(year) && month == 2)
                    return _miesiace[month] + 1;
                return _miesiace[month];
            }
            catch (Exception)
            {
                return UnallowedDay;
            }
        }
    }
}
