using System;
using System.Collections.Generic;
using System.Linq;

namespace Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.MyPeselValidator
{
    public static class DaysInMonthValidator
    {
        private static Dictionary<List<int>, Func<int, int>> _daysInMonth= new Dictionary<List<int>, Func<int, int>>(){
                {new List<int>(){1,3,5,7,8,10,12}, year => 31},
                {new List<int>(){2}, year => DateTime.IsLeapYear(year) ? 29 : 28},
                {new List<int>(){4,6,9,11}, year => 30},    
            };

        public static bool IsCorrectCountOfDays(int year, int month, int day)
        {
            var months = _daysInMonth.Keys.FirstOrDefault(x => x.Contains(month));
            return months != null && (day <= _daysInMonth[months](year) && day > 0);  
        }
    }
}