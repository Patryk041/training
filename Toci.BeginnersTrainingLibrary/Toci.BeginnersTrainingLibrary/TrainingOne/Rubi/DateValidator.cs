using System;
using Toci.BeginnersTrainingLibrary.TrainingOne.Rubi.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Rubi
{
    public class DateValidator:IDateValidator
    {
        public bool CheckDate(int year, int month, int day)
        {
            YearValidation years = new YearValidation();
            var yV = years.ValidYear(year);

            LeapsedCheck leapsed = new LeapsedCheck();
            var CL = leapsed.CheckLeapsed(day, month, year);

            MonthsCheck months = new MonthsCheck();
            var LongDays = months.CheckLongDaysInMonth(day, month);
            var ShortDays = months.CheckShortDaysInMonth(day, month);
            var FebruaryDays = months.CheckDayInFebruary(day, month);




            return (yV && (LongDays || ShortDays || FebruaryDays)) || (yV && CL);
        }

        public string GetNick()
        {
            return "Rubi//Rafał Rubiszewski";
        }
    }
}
