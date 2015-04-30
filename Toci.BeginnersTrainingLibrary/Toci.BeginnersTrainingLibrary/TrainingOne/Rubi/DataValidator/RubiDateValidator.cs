using System;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Rubi
{
    public class RubiDateValidator:IDateValidator
    {
        public bool CheckDate(int year, int month, int day)
        {
            YearValidation years = new YearValidation();
            DayValidation days = new DayValidation();
            MonthValidation monthValid = new MonthValidation();
            var yV = years.ValidYear(year);
            var dV = days.VerifyLongMonthDay(day);
            var mV = monthValid.ValidMonth(month);

            LeapsedCheck leapsed = new LeapsedCheck();
            var CL = leapsed.CheckLeapsed(day, month, year);

            MonthsCheck months = new MonthsCheck();
            var LongDays = months.CheckLongDaysInMonth(day, month);
            var ShortDays = months.CheckShortDaysInMonth(day, month);
            var FebruaryDays = months.CheckDayInFebruary(day, month);




            return yV && dV && mV && CL || yV && dV && mV && LongDays && ShortDays && FebruaryDays;
        }

        public string GetNick()
        {
            return "Rubi//Rafał Rubiszewski";
        }
    }
}
