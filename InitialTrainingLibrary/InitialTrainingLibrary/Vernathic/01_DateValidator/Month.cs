using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Vernathic._01_DateValidator
{
    public class Month
    {
        static bool IsCorrectMonth(int month)
        {
            if (month >= 1 && month <= 12)
                return true;
            else return false;
        }

        //enum Months
        //{
        //    January=1, February, March, 
        //    April, May, June, 
        //    July, August, September, 
        //    October, November, December
        //}

        public static int GetMonthLenght(int year,int month)
        {
            var M31 = new List<int> { 1, 3, 5, 7, 8, 10, 12 };
            var M30 = new List<int> { 4, 6, 9, 11 };
            if (IsCorrectMonth(month))
            {
                if (month == 2)
                {
                    if (LeapYear.IsLeapYear(year))
                        return 29;
                    else return 28;
                }
                else if (M30.Contains(month))
                    return 30;
                else if (M31.Contains(month))
                    return 31;
            }
            return 0;
        }
    }
}
