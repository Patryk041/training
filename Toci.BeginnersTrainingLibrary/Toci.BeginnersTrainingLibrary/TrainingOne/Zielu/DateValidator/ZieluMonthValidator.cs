using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.DateValidator
{
    public class ZieluMonthValidator
    {
        public int Validate(int year, int month)
        {
            int[] longer = { 1, 3, 5, 7, 8, 10, 12 };
            int[] shorter = { 4, 6, 9, 11 };
            var whatYear = new ZieluYearValidator();
            return longer.All(i => i == month) ? 32 : shorter.All(i => i == month) ? 31 : month == 2 ? (whatYear.Validate(year) ? 30 : 29) : 0;
        }
    }
}
