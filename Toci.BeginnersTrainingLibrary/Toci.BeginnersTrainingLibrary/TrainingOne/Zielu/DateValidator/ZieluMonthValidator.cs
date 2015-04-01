using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.DateValidator
{
    public class ZieluMonthValidator
    {
        public bool Validate(int Month)
        {
            return Month < 13 && Month > 0;
        }
    }
}
