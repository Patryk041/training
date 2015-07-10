using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.Rzeszow.Malwina;

namespace Toci.Hornets.Rzeszow.KSebal.traning2Homework.Pesel
{
    public class PeselDate
    {
        public int day {get; private set; }
        public int month { get;private set; }
        public int year { get; private set; }

        private Dictionary<int, int> AddVal = new Dictionary<int, int>()
        {
            {80, 1800},
            {0, 1900},
            {20, 2000},
            {40, 2100},
            {60, 2200}
        };

        private int[] daysofMonths = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};


        public PeselDate(string subpesel)
        {
            day = int.Parse(subpesel.Substring(4, 2));
            month = int.Parse(subpesel.Substring(2, 2));
            year = int.Parse(subpesel.Substring(0, 2));
        }

        public bool ValidateDateWithAddValue()
        {
            foreach (var item in AddVal)
            {
                if ((month - item.Key) >= 1 && (month - item.Key) <= 12)
                {
                    month -= item.Key;
                    year += item.Value;
                    return true;
                }
            }
            return false;
        }

        private bool CheckOther()
        {
            return daysofMonths.Any(item => daysofMonths[month - 1] >= day && day >= 1) ||
                   (isLeapYear(year) && daysofMonths[month - 1] + 1 >= day && day >= 1 && month == 2);
        }


        private bool isLeapYear(int year)
        {
            return ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
        }

        public bool ValidateDate(int year, int month, int day)
        {
            return ValidateDateWithAddValue() && CheckOther();
        }
    
    }

}
