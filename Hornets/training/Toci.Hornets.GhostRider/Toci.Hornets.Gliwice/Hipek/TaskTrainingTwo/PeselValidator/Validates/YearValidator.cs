using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Gliwice.Hipek.TaskTrainingTwo.PeselValidator.Validates
{
    public static class YearValidator
    {
        public static bool IsCorrect(int year)
        {
            return year >= 1;
        }

        public static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }
    }
}
