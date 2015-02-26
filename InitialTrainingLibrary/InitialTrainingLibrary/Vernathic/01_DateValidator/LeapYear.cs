using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Vernathic._01_DateValidator
{
    public class LeapYear
    {
        // if year%4 != 0 - it's common year
        // if year%4 == 0 && year%100 != 0 - it's leap year

        public static bool IsLeapYear(int year)
        {
            if (year % 4 != 0)
            {
                return false;
            }
            else if (year % 100 != 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
