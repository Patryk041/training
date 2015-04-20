using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Amman.DateValidator.Workers
{
    class DayValidator
    {
        private static Dictionary<int, int> daysInMonth = new Dictionary<int, int>()
        {
            //{ month, days}
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

        public static bool isValid(int day, int month, int year)
        {
            // CHECK IF DAY BETWEEN 1 - 31
            if (day > 31 || day < 1)
                return false;

            // CHECK IF DAY IS LESS THAN STATED IN DICTIONARY
            if (daysInMonth.ContainsKey(month))
                if (day <= daysInMonth[month])
                    return true;

            // CHECK FOR FEBRUARY
            if (month == 2)
            {
                // ACTUALLY, HOW MANY DAYS DOES FEB HAS?
                if (YearValidator.isLeap(year))
                {
                    // 29, YOU DUMMY
                    if (day <= 29)
                        return true;
                }
                else
                {
                    // 28, YOU DUMBASS
                    if (day <= 28)
                        return true;
                }
            }
            // IF IT ENDS HERE, SOMETHING WENT WRONG
            return false;


        }
    }
}
