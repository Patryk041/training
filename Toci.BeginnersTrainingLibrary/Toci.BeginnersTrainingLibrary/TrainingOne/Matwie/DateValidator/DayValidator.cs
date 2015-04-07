using System;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.DateValidator
{
    class DayValidator
    {
        private const int MinDay = 1;
        private const int DaysInShortFebruary = 28;
        private const int DaysInLongFebruary = 29;
        private const int DaysInShortMonth = 30;
        private const int DaysInLongMonth = 31;

        public static bool IsValid(int year, int month, int day)
        {
            if (day >= MinDay && day <= DaysInMonth(year, month))
                return true;
        
            throw new Exception();
        }

        private static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        private static int DaysInMonth(int year, int month)
        {
            switch (month)
            {
                case 4: //april
                case 6: //june
                case 9: //september
                case 11://october
                    return DaysInShortMonth;
                case 2: //february
                    return IsLeapYear(year) ? DaysInLongFebruary : DaysInShortFebruary;  
            }
            return DaysInLongMonth;
        }
    }
}
