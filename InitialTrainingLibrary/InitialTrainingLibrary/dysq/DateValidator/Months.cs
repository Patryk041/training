using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.dysq.DateValidator
{
    public static class Months
    {
        private static List<int> MonthsOf31 = new List<int>(7){1,3,5,7,8,10,12};
        private static List<int> MonthsOf30 = new List<int>(4){4,6,9,11};
        private static int MonthOf28 = 2; 

        private static int _maxMonth=12;
        private static int _minMonth=1;

        public static List<int> GetMonths31Days()
        {
            return MonthsOf31;
        }

        public static List<int> GetMonths30Days()
        {
            return MonthsOf30;
        }

        public static bool IsMonthCorrect(int month)
        {
            return month <= _maxMonth && month >= _minMonth;
           
        }

  
        public static bool Is28DaysMonth(int month)
        {
            return month == MonthOf28;
        }
 
    }
}
