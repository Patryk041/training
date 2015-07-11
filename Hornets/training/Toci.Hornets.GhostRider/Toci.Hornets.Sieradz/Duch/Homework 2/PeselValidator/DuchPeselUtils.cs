using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Sieradz.Duch.Homework_2.PeselValidator
{
    static class DuchPeselUtils
    {
        private const int MinMonths = 1;
        private const int MaxMonths = 12;
        private const int MaxDaysInMonth = 31;
        private const int MinDaysInMonth = 1;
        private const int PeselLenght = 11;


        public static bool IsMonthLenghtValid(int month)
        {
            return
                month <= MaxMonths &&
                month >= MinMonths;
        }
        public static bool IsDayAmountValid(int day)
        {
            return day <= MaxDaysInMonth && day >= MinDaysInMonth;
        }
        public static bool IsPeselLenghtValid(string pesel)
        {
            return pesel.Length == PeselLenght;
        }

        public static int[] PeselDateMagic(string peselDate)
        {
            
            var date = new int[3];
            Int32.TryParse(peselDate.Substring(0, 2), out date[0]);
            Int32.TryParse(peselDate.Substring(2, 2), out date[1]);
            Int32.TryParse(peselDate.Substring(4, 2), out date[2]);
            return date;
        }

    }
}
