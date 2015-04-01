using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.DateValidator
{
    public class ZieluYearValidator
    {
        public bool Validate(int Year)
        {
            return ((Year%4 == 0 && Year%100 != 0) || Year%400 == 0);
        }
    }
}
