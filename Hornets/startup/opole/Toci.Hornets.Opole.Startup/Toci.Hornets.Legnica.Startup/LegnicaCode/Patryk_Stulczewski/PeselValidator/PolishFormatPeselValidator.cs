using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.TrainingTwo.Homework;

namespace Toci.Hornets.Legnica.Startup.LegnicaCode.Patryk_Stulczewski
{
    public class PolishFormatPeselValidator : PeselValidator
    {
        private Dictionary<int, int> daysInMonth;

        public PolishFormatPeselValidator()
        {
            daysInMonth = new Dictionary<int, int>{
                {1,31}, {2,28}, {3,31}, {4,30}, {5,31}, {6,30},
                {7,31}, {8,31}, {9,30}, {10,31}, {11,30}, {12,31}
            };
        }

        public override bool IsPeselValid(string pesel){
            if (pesel == null || !( Regex.IsMatch(pesel, "^[0-9]{11}$") ) )
                return false;

            return ValidateDate( pesel.SubstringToInt(0,2),
                                 pesel.SubstringToInt(2, 2),
                                 pesel.SubstringToInt(4, 2) );
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            if(IsCorrectDate(year, month % 20, day))
                return !IsDateInFuture(year, month, day);
            return false;
        }

        public bool IsCorrectDate(int year, int month, int day)
        {
            if ( month == 2 && DateTime.IsLeapYear(year) )
                day -= 1;
            return daysInMonth.ContainsKey(month) ? daysInMonth[month] >= day : false;
        }

        public bool IsDateInFuture(int year,int month, int day){
            if (month <= 12)
                return false;
            DateTime dt = new DateTime(year + 2000, month % 20, day);
            return dt > DateTime.Now;
        }
    }
}
