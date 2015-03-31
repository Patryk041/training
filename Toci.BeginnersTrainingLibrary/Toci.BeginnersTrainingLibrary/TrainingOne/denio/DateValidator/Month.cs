using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.denio.DateValidator
{
    public class Month
    {
        private const int MinimumMonthNumber = 1;
        private const int MaximumMonthNumber = 13;

        public bool ValidMonth(int month)
        {
            return month >= MinimumMonthNumber && month < MaximumMonthNumber;
        }
    }
}
