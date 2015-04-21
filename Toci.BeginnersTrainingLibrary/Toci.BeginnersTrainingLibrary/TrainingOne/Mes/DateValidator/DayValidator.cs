using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Mes.DateValidator
{
    class DayValidator
    {
        private const int leapFebruaryDays = 29;
        private const int nonLeapFebruaryDays = 28;
        private const int minimumDays = 1;

        private static Dictionary<int, int> monthDays = new Dictionary<int, int>()
        {
            {1,31},
            {2,29},
            {3,31},
            {4,30},
            {5,31},
            {6,30},
            {7,31},
            {8,31},
            {9,30},
            {10,31},
            {11,30},
            {12,31}
        };

        public static bool ValidateDay(int day, int month, int year)
        {
            if (month == 2)
            {
                // luty
                return YearValidator.IsLeapYear(year) ? day >= minimumDays && day <= leapFebruaryDays : day >= minimumDays && day <= nonLeapFebruaryDays;
            }
            else
            {
                // pozostale
                return day >= minimumDays && day <= monthDays[month] ? true : false;
            }
        }
    }
}
