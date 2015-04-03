using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie
{
    class YearValidator
    {
        private const int MIN_YEAR = 1000;
        private const int MAX_YEAR = 2500;

        internal bool isValid(int year, int month, int day)
        {
            return year >= MIN_YEAR && year <= MAX_YEAR;
        }
    }
}
