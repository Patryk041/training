using System;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Foonesh.TrainingTwo.PeselValidator
{
    public class PeselValidatorFoonesh : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {

        private bool IsLeap(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) return true;
            return false;
        }

        private int GetMonth(int year, int month)
        {
            if (year >= 1800 && year < 1900) return month + 80;
            if (year >= 2000 && year < 2100) return month + 20;
            if (year >= 2100 && year < 2200) return month + 40;
            if (year >= 2200 && year < 2300) return month + 60;
            return month;
        }

        bool ValidateYear(int year)
        {
            if (year > 2299 || year < 1800) return false;
            return true;

        }

        bool ValidateMonth(int year, int month)
        {
            if (GetMonth(year,month) > 12 || GetMonth(year,month) < 1) return false;
            return true;
        }

        private bool ValidateDay(int year, int month, int day)
        {
            month = GetMonth(year, month);

            if (day > 31 || day < 1) return false;

            if (month == 4 || month == 6 || month == 9 || month == 11)
                if (day > 30) return false;
            if (month == 2)
            {
                if (IsLeap(year))
                {
                    if (day > 29) return false;
                }
                else if (day > 28) return false;
            }
            return true;
        }

        protected override string CutOffDate(string pesel)
        {
            return pesel.Remove(0, 6);
        }

        protected override bool Checksum(string pesel)
        {
            return 10 -
                   (pesel[0] + 3 * pesel[1] + 7 * pesel[2] + 9 * pesel[3] + pesel[4] + 3 * pesel[5] + 7 * pesel[6] + 9 * pesel[7] +
                    pesel[8] + 3 * pesel[9]) % 10 == pesel[10];
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            return ValidateYear(year) && ValidateMonth(year, month) && ValidateDay(year, month, day);
        }

        public override string GetNick()
        {
            return "foonesh";
        }

        public override bool IsPeselValid(string pesel)
        {
            int year = Convert.ToInt32(pesel.Substring(0, 2));
            int month = Convert.ToInt32(pesel.Substring(2, 2));
            int day = Convert.ToInt32(pesel.Substring(4, 2));

            return ValidateDate(year, month, day) && Checksum(pesel);
        }
    }
}