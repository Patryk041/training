using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Chmura.DateTimeValidator
{
    public class DateValidator
    {
        private Year year;
        private Month month;
        private Day day;


        public bool DateValidate(int y, int m, int d)
        {
            year = new Year(y);
            month = new Month(m);
            day = new Day(d);

            return year.validate() && month.Validate() && day.Validate(month, year);

        }



        public string GetName()
        {
            return "chmura";
        }
    }
}
