using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.DateValidator
{
    public class ZieluDayValidator
    {

        public bool Validate(int day, int month, int year)
        {
            var whatMonth = new ZieluMonthValidator();
            return whatMonth.Validate(year, month) > day && day > 0;
        }
    }
}
