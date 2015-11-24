using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Anathema.Rhonin.DataValidator
{
    /// <summary>
    /// 
    /// </summary>
    public static class ValidatorDay
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static bool ValidateDay(int day, int month, int year)
        {
            Dictionary<List<int>,Func<int,bool>> daysDictionary = new Dictionary<List<int>, Func<int, bool>>()
            {
                {
                    new List<int>() {2}, (d) =>
                    {
                        if (DateTime.IsLeapYear(year))
                        { return d > 0 && d < 30; }
                        else
                        { return d > 0 && d < 29; }
                    }
                },
                   { new List<int>() {1,3,5,7,8,10,12}, (d) => d > 0 && d < 32 },
                { new List<int>() {4,6,9,11}, (d) => d > 0 && d < 31}
            };
            var key = daysDictionary.Keys.FirstOrDefault(x => x.Contains(month));
            if (key != null)
            {
                return daysDictionary[key].Invoke(day);
            }
            else
            {
                return false;
            }
        }

        //private static bool IsLeapYear(int year)
        //{
        //    return ((year%4 == 0 && year%100 != 0) || year%400 == 0);
        //}
    }
}