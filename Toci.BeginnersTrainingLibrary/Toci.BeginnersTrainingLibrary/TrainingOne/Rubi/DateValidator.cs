using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateValidator
{
    public class DateValidator:IDateValidator
    {
        public bool CheckDate(int year, int month, int day)
        {
            YearValidation yV = new YearValidation();
            var k = yV.ValidYear(year);
            var l = yV.ValidLeapsed(year);
            MonthValidation mV = new MonthValidation();
            mV.ValidMonth(month);
            DayValidation dV = new DayValidation();
            //dV.

            


            return true;
        }

        public string GetNick()
        {
            return "Rubi";
        }
    }
}
