using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.denio.DateValidator
{
    public class DateValidator : IDateValidator
    {
        private int day;
        private int month;
        private int year;


        public bool DateValidate(int ye, int mo, int da)
        {
            day = da;
            month = mo;
            year = ye;

            Day d = new Day();
            Month m = new Month();
            Year y = new Year();

            return d.ValidDay(day, month, year) && m.ValidMonth(month) && y.ValidYear(year);
        }

        public string GetName()
        {
            return "denio";
        }
    }
}
