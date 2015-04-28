using DateValidator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateValidator
{
    public class YearValidation:IYearValidation
    {

        private const int MinYear = 0;
        public bool ValidYear(int year)
        {
            return year > MinYear;
        }


        public bool ValidLeapsed(int year)
        {
            return year % 4 == 0 ? true : false;
        }
    }
}
