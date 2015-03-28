using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Wiosna.DateValidator.DateParts;
using InitialTrainingLibrary.Wiosna.DateValidator.WiosnaInterfaces;

namespace InitialTrainingLibrary.Wiosna.DateValidator
{
    public class DayValidation : IDayValidation
    {

        public bool DayValid(int _day,int _month)
        {
            MonthAndMonthLength monthAndMonthLength = new MonthAndMonthLength();
            
            return (monthAndMonthLength.GetMonth(_month,_day));
        }
    }
}
