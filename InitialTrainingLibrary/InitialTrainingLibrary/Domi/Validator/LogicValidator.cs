using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.koziu.DateValidator;

namespace InitialTrainingLibrary.Domi.Validator
{
    class LogicValidator
    {
        private int years;
        private int months;
        private int days;
        private int monthLeap;
        private int MaxDay;
        private int yearL;

        private static int d31 = 31;
        private static int d28 = 28;
        private static int d30 = 30;

        private Dictionary<int, int> daysCount = new Dictionary<int, int>()
        {
            { 1, d31 },
            { 2, d28 },
            { 3, d31 },
            { 4, d30 },
            { 5, d31 },
            { 6, d30 },
            { 7, d31 },
            { 8, d31 },
            { 9, d30 },
            { 10, d31 },
            { 11, d30 },
            { 12, d31 },
        };

        public LogicValidator() { }
        public LogicValidator(int year, int month, int day)
        {
            this.years = year;
            this.months = month;
            this.days = day; 
        }


        public bool CheckYear()
        {
            if (1 > years || years > 3000)
                return false;
            else
            {
                if ((years%4 != 0) || (years%100 == 0) || (years%400 != 0))
                    years = years;
                else
                {
                    yearL = years;
                }
                return true;
            }
        }


        public bool CheckMonth() //ilosc dni dla miesiaca i czy miesiąc poprawny 
        {
            if (!daysCount.ContainsKey(months))
                return false;
            else
            {
                MaxDay = months == 2 && yearL == years ? 29 : daysCount[months];
                return true;
            }
        }

        public bool CheckDay()
        {
            return 1 <= days && days <= MaxDay;
        }
    }
}
