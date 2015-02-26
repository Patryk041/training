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

        private static int day31 = 31;
        private static int day28 = 28;
        private static int day30 = 30;

        private Dictionary<int, int> daysCount = new Dictionary<int, int>()
        {
            { 1, day31 },
            { 2, day28 },
            { 3, day31 },
            { 4, day30 },
            { 5, day31 },
            { 6, day30 },
            { 7, day31 },
            { 8, day31 },
            { 9, day30 },
            { 10, day31 },
            { 11, day30 },
            { 12, day31 },
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
            if (1 <= years && years <= 3000)
            {
                if ((years%4 == 0) && (years%100 != 0) && (years%400 == 0))
                {
                    yearL = years;
                }
                else years = years;
                return true;
            }
            else return false;
        }


        public bool CheckMonth() //ilosc dni dla miesiaca i czy miesiąc poprawny 
        {
            if (daysCount.ContainsKey(months))
            {
                MaxDay = months == 2 && yearL == years ? 29 : daysCount[months];
                return true;
            }
            else return false;
        }

        public bool CheckDay()
        {
            if (1 <= days && days <= MaxDay)
            {
                return true;
            }
            else return false;
        }
    }
}
