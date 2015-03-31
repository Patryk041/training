using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zly
{
    public class DayValidation
    {
        private int _day;


        public DayValidation(int day)
        {
            _day = day;
        }


        public bool Validate(MonthValidation monthPar, YearValidation yearPar)
        {
            return (_day > 0 && _day <= monthPar.NumberOfDaysInMonth(yearPar));
        }


    }
}
