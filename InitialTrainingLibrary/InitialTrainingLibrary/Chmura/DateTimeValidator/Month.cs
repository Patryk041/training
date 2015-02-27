using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Chmura.DateTimeValidator
{
    class Month
    {
        private int month;

        private Dictionary<int,int> monthDayCounter = new Dictionary<int, int>()
        {
            { 1, 31 },
            { 3, 31 },
            { 4, 30 },
            { 5, 31 },
            { 6, 30 },
            { 7, 31 },
            { 8, 31 },
            { 9, 30 },
            { 10, 31 },
            { 11, 30 },
            { 12, 31 },
        }; 

        public Month(int m)
        {
            month = m;
        }

        public int GetDayCount(Year y)
        {
            if (month == 2)
            {
                return (y.isLeapYear() == true) ? 28 : 27;
            }
            else
            {
                if (monthDayCounter.ContainsKey(month))
                {
                    return monthDayCounter[month];
                }
                else
                {
                    return 0;
                }
            }
        }

        public bool Validate()
        {
            return month > 0 && month < 13;
        }
    }
}
