using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.denio.DateValidator
{
    public class Year
    {
        
        private int year;
        private const int MinimumYear = 1900;
        private const int MaximumYear = 2100;

        public bool Przestepny(int y)
        {
            if ((y % 4 == 0) && (y % 100 != 0) || (y % 400 == 0))
            {
                
                return true;
            }
            return false;
        }

        public bool ValidYear(int y)
        {
            year = y;
            return year >= MinimumYear && year < MaximumYear;
        }
    }
}
