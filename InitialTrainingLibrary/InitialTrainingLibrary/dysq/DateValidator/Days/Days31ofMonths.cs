using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.dysq.DateValidator.Days
{
    public static class Days31ofMonths
    {
        private static int _maxDay = 31;
        private static int _minDay = 1;

        public static bool IsCorrect(int day)
        {
            return day >= _minDay && day <= _maxDay;
        }
    }
}
