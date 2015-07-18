using System;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Foonesh.TrainingTwo.PeselValidator
{
    public class PeselValidatorFoonesh : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {

        private bool IsLeap(int year, int month)
        {
            int realYear = GetYear(year, month);
            if ((realYear % 4 == 0 && realYear % 100 != 0) || realYear % 400 == 0) return true;
            return false;
        }

        private int GetYear(int year, int month)
        {
            if (month >= 1 && month <= 12)
                return year + 1900;
            if (month >= 21 && month <= 32)
                return year + 2000;
            if (month >= 41 && month <= 52)
                return year + 2100;
            if (month >= 61 && month <= 72)
                return year + 2200;
            if (month >= 81 && month <= 92)
                return year + 1800;
            return 0;
        }

        private int GetMonth(int month)
        {
            return month%20;
        }

        bool ValidateYear(int year)
        {
            return true;
        }

        bool ValidateMonth(int year, int month)
        {
            if  ((month >= 1 && month <= 12)||
                (month >= 21 && month <= 32)||
                (month >= 41 && month <= 52)||
                (month >= 61 && month <= 72)||
                (month >= 81 && month <= 92)) return true;

            return false;
        }

        private bool ValidateDay(int year, int month, int day)
        {
            month = GetMonth(month);

            if (day > 31 || day < 1) return false;

            if (month == 4 || month == 6 || month == 9 || month == 11)
                if (day > 30) return false;
            if (month == 2)
            {
                if (IsLeap(year, month))
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
            return (10 -
                   (Int32.Parse(pesel.Substring(0, 1)) + 3 * Int32.Parse(pesel.Substring(1, 1)) + 7 * Int32.Parse(pesel.Substring(2, 1)) + 9 * Int32.Parse(pesel.Substring(3, 1)) + Int32.Parse(pesel.Substring(4, 1)) + 3 * Int32.Parse(pesel.Substring(5, 1)) + 7 * Int32.Parse(pesel.Substring(6, 1)) + 9 * Int32.Parse(pesel.Substring(7, 1)) +
                    Int32.Parse(pesel.Substring(8, 1)) + 3 * Int32.Parse(pesel.Substring(9, 1))) % 10 == Int32.Parse(pesel.Substring(10, 1)));
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