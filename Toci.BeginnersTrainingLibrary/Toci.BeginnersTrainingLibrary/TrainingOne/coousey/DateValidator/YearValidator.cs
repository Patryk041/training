using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.coousey.DateValidator
{
    class YearValidator : IValidator
    {
        public void Validate(Date date)
        {          
            if((date.Year < 0) || (date.Year > 9999))
            {
                 date.YearIsValid = false;
            }
        }
    }
}
