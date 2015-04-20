using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Amman.DateValidator.Workers
{
    public class YearValidator
    {
        public static bool isLeap(int year)
        {
            /*
             * WIKI:
             * if (year is not exactly divisible by 4) then (it is a common year)
             * else
             * if (year is not exactly divisible by 100) then (it is a leap year)
             * else
             * if (year is not exactly divisible by 400) then (it is a common year)
             * else (it is a leap year)
             */

            if (year % 4 != 0) 
                return false;
            else if (year % 100 != 0) 
                return true;
            else if (year % 400 != 0) 
                return false;
            else 
                return true;
        }
    }
}
