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
                if (month.GetMonth() % 2 == 1 && month.GetMonth() < 8) result = (_day > 0 && _day < 32) ? true : false;
                else if (month.GetMonth() % 2 == 1 && month.GetMonth() > 8) result = (_day > 0 && _day < 31) ? true : false;
                else if (month.GetMonth() % 2 == 0 && month.GetMonth() != 2 && month.GetMonth() < 7) result = (_day > 0 && _day < 31) ? true : false;
                else if (month.GetMonth() % 2 == 0 && month.GetMonth() > 7) result = (_day > 0 && _day < 32) ? true : false;
                else
                {
                    if (year.isIntercalary()) result = (_day > 0 && _day < 29) ? true : false;
                    else if (!year.isIntercalary()) result = (_day > 0 && _day < 28) ? true : false;   
                }
                
            }
            else result = false;

           

            return result;
        }
                    

    }
}
