using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie
{
    class MonthValidator
    {
        private const int MIN_MONTH = 1;
        private const int MAX_MONTH = 12;

        internal bool isValid(int year, int month, int day)
        {
            return month >= MIN_MONTH && month <= MAX_MONTH;
        }
    }
}
