using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

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
            try
            {
                if (1 > years || years > 3000)
                {
                    return false;
                }
                else
                {
                    if ((years % 4 == 0) && (years % 100 != 0) || (years % 400 == 0))
                    {
                        yearL = years;
                    }
                    return true;
                    //ghdg
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool CheckMonth() //ilosc dni dla miesiaca i czy miesiąc poprawny 
        {
            try
            {
                if (months <1 || months >12)
                    return false;
                else
                {
                    if (months == 2 && yearL == years)
                        MaxDay = 29;
                    else
                        MaxDay = daysCount[months];
                    
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CheckDay()
        {
            try
            {
                if (1 <= days && days <= MaxDay)
                    return true;
                else return false; 
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
