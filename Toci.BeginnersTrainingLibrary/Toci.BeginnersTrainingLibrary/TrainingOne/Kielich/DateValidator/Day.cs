using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Kielich
{
    public class Day
    {
        private const int minDay = 1;

        private int day;

        public Day(int day)
        {
            this.day = day;
        }

        public bool Validate(Month month, Year year)
        {
            return day > minDay && day <= month.Day(year);
        }
    }
}
