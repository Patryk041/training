using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Kielich
{
    public class Validator
    {
        Day day;
        Month month;
        Year year;

        public bool Validation(int d, int m, int y)
        {
            day = new Day(d);
            month = new Month(m);
            year = new Year(y);

            return day.Validate(month, year) && month.Validate() && year.Validate();
        }
    }
}
