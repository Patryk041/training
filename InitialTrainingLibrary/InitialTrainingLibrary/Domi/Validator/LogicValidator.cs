using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.dysq.DateValidator.Days;
using InitialTrainingLibrary.syf.privatelol;

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

        private static int february =2;
        private static int maxYear =3000 ;
        private static int minYear = 0; 
        private static int minDay= 1; 

        private static int d31 = 31;
        private static int d30 = 30; 
        private static int d28 = 28; 
        private static int d29 = 29; 

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
                if ( years < minYear || years > maxYear)
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
                }
        }

        public bool CheckMonth() //ilosc dni dla miesiaca i czy miesiąc poprawny 
        {
              if (!daysCount.ContainsKey(months))
              {return false;}
                else
                {
                    if (months == february && yearL == years)
                    {  MaxDay = d29;}
                    else
                    { MaxDay = daysCount[months];}
                    
                    return true;
                }
        }

        public bool CheckDay()
        {
                if (days >= minDay && days <= MaxDay)
                {return true;}
                else {return false;} 
        }
    }
}
