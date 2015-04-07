using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.S2yfr4nt.DateValidator
{

    public class S2yfr4ntDateValidator: IDateValidator
    {
        public bool CheckDate(int year, int month, int day)
        {
            return S2yfr4ntYearValidation.ValidateYear(year) && S2yfr4ntMonthValidation.ValidateMonth(month) &&
                   S2yfr4ntDayValidation.ValidateDay(year, month, day);
        }

        public string GetNick()
        {
            return "S2yfr4nt";
        }
    }
}
