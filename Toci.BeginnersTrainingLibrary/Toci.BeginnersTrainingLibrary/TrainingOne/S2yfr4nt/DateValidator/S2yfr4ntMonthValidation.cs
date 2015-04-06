using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.S2yfr4nt.DateValidator
{
    class S2yfr4ntMonthValidation
    {
        public static bool ValidateMonth(int month)
        {
            return (month>0 && month<13);
        }
    }
}
