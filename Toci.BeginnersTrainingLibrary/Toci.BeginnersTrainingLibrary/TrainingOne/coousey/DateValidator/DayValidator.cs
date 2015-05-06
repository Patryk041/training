using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.coousey.DateValidator
{
    class DayValidator : IValidator
    {
        public void Validate(Date date)
        {
            bool leapYear = ((date.Year % 400 == 0) || (date.Year % 4 == 0)) && (date.Year % 100 != 0);

            if ((((date.Month == 4) || (date.Month == 6) || (date.Month == 9) || (date.Month == 11)) && (date.Day > 30)) ||
            ((date.Month == 2) && leapYear && (date.Day > 29)) ||
            ((date.Month == 2) && (date.Year % 100 == 0) && (date.Day > 29))) date.DayIsValid = false;
        }
    }
}
