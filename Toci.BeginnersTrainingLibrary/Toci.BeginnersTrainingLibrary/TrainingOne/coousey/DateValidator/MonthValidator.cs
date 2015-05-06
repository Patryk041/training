using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.coousey.DateValidator
{
    class MonthValidator : IValidator
    {
        public void Validate(Date date)
        {
            if ((date.Month < 1) || (date.Month > 12))
            {
                date.MonthIsValid = false;
            }
        }
    }
}
