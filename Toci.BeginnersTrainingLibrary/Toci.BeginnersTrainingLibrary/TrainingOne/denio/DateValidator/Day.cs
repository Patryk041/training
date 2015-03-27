using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.denio.DateValidator
{
    public class Day
    {
        private int day;
        private int year;
        private int month;

        public bool ValidDay(int day, int month, int year)
        {
            day = day;
            year = year;
            month = month;

            Month mon = new Month();
            return day >= 1 && day <= mon.dayNumber(month, year);
        }
    }
}
