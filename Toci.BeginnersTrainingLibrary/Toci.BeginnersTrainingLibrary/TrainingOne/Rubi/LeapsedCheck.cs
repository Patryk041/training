using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Rubi
{
    public class LeapsedCheck
    {
        
        public bool CheckLeapsed(int day, int month, int year)
        {
            YearValidation years = new YearValidation();
            var vY = years.ValidYear(year);
            var vL = years.ValidLeapsed(year);

            MonthValidation months = new MonthValidation();
            var vM = months.ValidMonth(month);
            var cF = months.CheckFebruary(month); 

            DayValidation days = new DayValidation();
            var dV = days.VerifyLongFebruaryDay(day);


            return vY.Equals(vL.Equals(vM.Equals(cF.Equals(dV))));
        }
        
    }
}
