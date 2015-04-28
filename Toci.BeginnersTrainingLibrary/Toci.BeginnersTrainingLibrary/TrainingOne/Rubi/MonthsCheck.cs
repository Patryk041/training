using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Rubi
{
    public class MonthsCheck
    {

        public bool CheckLongDaysInMonth(int day, int month)
        {
            MonthValidation months = new MonthValidation();
            DayValidation days = new DayValidation();

            var vM =months.ValidMonth(month);
            var cM=months.CheckMonth(month);
            var vs =days.VerifyShortMonthDay(day);

            return vM.Equals(cM.Equals(vs));
        }
        public bool CheckShortDaysInMonth(int day, int month)
        {
            MonthValidation months = new MonthValidation();
            DayValidation days = new DayValidation();

            var vM = months.ValidMonth(month);
            var cM = months.CheckMonth(month);
            var vs = days.VerifyLongMonthDay(day);

            return !cM && vM.Equals(vs);
        }

        public bool CheckDayInFebruary(int day, int month)
        {
            MonthValidation months = new MonthValidation();
            DayValidation days = new DayValidation();

            var vM = months.ValidMonth(month);
            var cF = months.CheckFebruary(month);
            var vSF = days.VerifyShortFebruaryDay(day);

            return vM.Equals(cF.Equals(vSF));

        }

    }
}
