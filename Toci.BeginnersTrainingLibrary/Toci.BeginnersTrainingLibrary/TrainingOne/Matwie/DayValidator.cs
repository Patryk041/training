using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie
{
    class DayValidator
    {
        private const int MIN_DAY = 1;

        internal bool isValid(int year, int month, int day)
        {
            return day >= MIN_DAY && day <= DateTime.DaysInMonth(year, month);
        }
    }
}
