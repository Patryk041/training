using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.DateValidator
{
    public class ZieluDayValidator
    {
        private readonly var longer = {1, 3, 5, 7, 8, 10, 12};
        private var shorter = {4, 6, 9, 11};
        public bool Validate(int Day, int Month, int Year)
        {
            if (Day < 0) return false;
            var cos = new ZieluYearValidator();
            if (longer.Any(number=> Month==number)) return 32 > Day;
            if (shorter.Any(number => Month == number)) return 31 > Day;
            else return cos.Validate(Year) ? 30 > Day : 29 > Day;
        }
    }
}
