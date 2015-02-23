using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Sito._1
{
    public class DayValidator:DatePartValidator
    {
        private Dictionary<List<int>, Func<int, int, bool>> daysPerMonthDictionary = new Dictionary
            <List<int>, Func<int, int, bool>>()
        {
           {new List<int>(){2}, (d, y) =>
           {
               if (IsLeapYear(y))
                   return d > 0 && d < 30;
               else
                   return d > 0 && d < 29;
           }},
           {new List<int>() { 1, 3, 5, 7, 8,10,12 }, (d,y) => d >0 && d<32},
           {new List<int>() { 4,6,9,11 }, (d, y) => d > 0 && d < 31}

        };
        public static bool IsLeapYear(int year)
        {
            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
        }

        public override bool ValidatePart(int d, int m, int y)
        {
            var key = daysPerMonthDictionary.Keys.FirstOrDefault(x => x.Contains(m));
            return daysPerMonthDictionary[key].Invoke(d, y);
        }
    }
}
