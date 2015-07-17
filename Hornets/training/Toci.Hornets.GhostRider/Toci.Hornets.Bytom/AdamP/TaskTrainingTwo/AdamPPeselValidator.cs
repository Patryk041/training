using System;
//using System.Runtime.Remoting.Messaging;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Bytom.AdamP.TaskTrainingTwo
{
    public class AdamPPeselValidator : PeselValidator
    {
        private bool IsProperLength(string pesel)
        {
            return (pesel.Length == 11);
        }

        private bool IsProperDateFormat(string peselDate)
        {
            return (peselDate.Length == 6);
        }

        private bool ValidateMonth(int month)
        {
            for (int monthCounter = 1; (monthCounter < 13); monthCounter++)
            {
                if (((month - monthCounter)%20) == 0) return true;
            }
            return false;
        }

        private bool ValidateYear(int year)
        {
            return ((year < 100) && (year >= 0));
        }

        private bool IsLeapYear(int year)
        {
            return (((year%4) == 0) && (year != 0));
        }

        private bool ValidateDay(int day, int month, int year)
        {
            if (IsLeapYear(year) && (((month%20) - 1) == 2)) return (day < 30) && (day > 0);

            int[] possibleDayNumbers = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            return (day <= possibleDayNumbers[(month%20) - 1]) && (day > 0);
        }

        private SimpleDate ParseDate(string peselDate)
        {
            return new SimpleDate(Int32.Parse(peselDate.Substring(0, 2)), Int32.Parse(peselDate.Substring(2, 2)), Int32.Parse(peselDate.Substring(4, 2)));
        }

        protected override string CutOffDate(string pesel)
        {
            return IsProperLength(pesel) ? pesel.Substring(0, 6) : null;
        }

        protected override bool Checksum(string pesel)
        {
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            
            var sum = 0;
            
            if (!IsProperLength(pesel)) return false;
            
            for(var counter = 0; counter < 10; counter++)
            {
                sum += (int.Parse(pesel.Substring(counter, 1)) * weights[counter]);
            }
            
            return (((sum % 10) == 0) && (int.Parse(pesel.Substring(10, 1)) == 0)) || (int.Parse(pesel.Substring(10, 1)) == (10 - (sum % 10)));
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            return ValidateMonth(month) && ValidateDay(day, month, year) && ValidateYear(year);
        }

        public override string GetNick()
        {
            return "AdamP";
        }

        public override bool IsPeselValid(string pesel)
        {
            var date = ParseDate(CutOffDate(pesel));
            return (date != null) && (ValidateDate(date.getYear(), date.getMonth(), date.getDay()) && Checksum(pesel));
        }
    }
}