using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.denio.DateValidator
{
    public class DateValidator : IDateValidator
    {

        private int day;
        private int month;
        private int year;

        public bool CheckDate(int ye, int mo, int da)
        {
            day = da;
            month = mo;
            year = ye;

            Day d = new Day();
            Month m = new Month();
            Year y = new Year();

            return d.ValidDay(day, month, year) && m.ValidMonth(month) && y.ValidYear(year);
        }

        public string GetNick()
        {
            return "denio";
        }
    }
}
