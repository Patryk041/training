using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.koziu.DateValidator
{
    public class Year
    {
        private int _year;

        public Year(int year)
        {
            _year = year;               
        }
        public bool isIntercalary()
        {
            return ((_year%4 == 0 && _year%100 != 0)|| _year % 400 == 0) ? true : false;
        }
    }
}
