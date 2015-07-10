using System;
using System.Linq;
using Microsoft.SqlServer.Server;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Agata.TasksTrainingTwo
{
    public class YaghaPeselValidator : PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0,6);
        }

        protected override bool Checksum(string pesel)
        {
            int[] digitImportance = new int[10]{1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
            var sum = digitImportance.Select((t, i) => Int32.Parse(pesel[i].ToString())*t).Sum();
            return ((10 - (sum % 10)) == Int32.Parse(pesel[10].ToString()));
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            int[] digitOfDaysInMonth = new int[12]{31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            if (month != 2 && month < 13)
            {
                return day <= digitOfDaysInMonth[month];
            }
            else if (month == 2)
            {
                return (LeapYearCheck(year)) ? day <= digitOfDaysInMonth[month]+1 : day <= digitOfDaysInMonth[month];
            }
            return false;
        }

        public override string GetNick()
        {
            return "yagha";
        }

        public override bool IsPeselValid(string pesel)
        {
            var date = new Date(CutOffDate(pesel));
            return ValidateDate(date.year, date.month, date.day) && Checksum(pesel);
        }

        private bool LeapYearCheck(int year)
        {
            return (year%4 == 0 && year%100 != 0) || year%400 == 0;
        }
    }
}