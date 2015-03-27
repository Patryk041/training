using System;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha
{
    public class DateValidator : IDateValidator
    {
        public bool CheckDate(int y, int m, int d)
        {
            Month month = new Month(m);
            Day day = new Day(d);

            if (!month.checMonthValidate())
                return false;

            bool isLeapYear = Year.leapYearCheck(y);
            int maxDaysInMonth = month.getMonthDaysCount(isLeapYear);

            if (!day.checkDayValidate(maxDaysInMonth))
                return false;

            return true;
        }

        public string GetNick()
        {
            return "By Marek Reszke";
        }
    }
}
