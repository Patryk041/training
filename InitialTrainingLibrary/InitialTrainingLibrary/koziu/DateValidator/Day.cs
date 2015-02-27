using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.koziu.DateValidator.Interfaces
{
    public class Day
    {
        private int _day;
        public Day(int day)
        {
            _day = day;               
        }     
        public bool isDay(Year year, Month month)
        {
            bool result = false;               

            if (month.isMonth())
            {
                if (IsCorrectDay(month, _day))
                {
                    return true;
                }
                else
                {
                    if (year.isIntercalary()) result = (_day > 0 && _day < 29) ? true : false;
                    else if (!year.isIntercalary()) result = (_day > 0 && _day < 28) ? true : false;   
                }
                
            }
            else result = false;

           

            return result;
        }

        private bool IsCorrectDay(Month month, int day)
        {
            return month.GetDaysCount() > 0 && month.GetDaysCount() >= day;
        }
    }
}
