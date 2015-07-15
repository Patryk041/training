using System;
using System.Diagnostics.CodeAnalysis;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Sherpin.TasksTrainingTwo
{
    public class SherPeselValidator : PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0, 6);
        }
        // Sprawdza czy rok jest przestępny
        private bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) return true;
            return false;
        }

        protected override bool Checksum(string pesel)
        {
            int[] tabMultipliers = new int[10] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int[] tabPesel = new int[11];
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
              sum += (tabMultipliers[i]*Int32.Parse(pesel[i].ToString())) % 10;
            }
            if ((10 - (sum%10)) == tabPesel[10] ) return true;
            return false;
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            int[] MaxDaysInMoth = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month != 2 && month < 13)
            {
                if (day <= MaxDaysInMoth[month-1]) return true;
                return false;
            }
            if (month == 2)
            {
                if (IsLeapYear(year))
                {
                    if (day <= MaxDaysInMoth[month-1] + 1) return true;
                    return false;
                }
                if (day <= MaxDaysInMoth[month]) return true;
                return false;
            }
            return false;
        }

        public override string GetNick()
        {
            return "Sherpin";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11) return false;
            var date = new SherDateValidator(CutOffDate(pesel));
            return ValidateDate(date.year, date.month, date.day) && Checksum(pesel);
        }
    }
}