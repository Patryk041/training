using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Chmura.DateTimeValidator
{
    class Day
    {
        private int day;

        public Day(int d)
        {
            day = d;
        }

        public bool Validate(Month m, Year y)
        {
            return (day > 1 && day <= m.GetDayCount(y));
        }
    }
}
