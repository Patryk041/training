using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.Gliwice.Hipek.TaskTrainingTwo.PeselValidator.Validates;

namespace Toci.Hornets.Gliwice.Hipek.TaskTrainingTwo.PeselValidator
{
    public class HipekPeselValidator : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        private Dictionary<int, int> monthsDictionary = new Dictionary<int, int>
        {
            {0, 0},
            {1, 20},
            {2, 40},
            {3, 60},
            {4, 80}
        }; 

        private Dictionary<int, int> stulecieDictionary = new Dictionary<int, int>
        {
            {0, 19},
            {20, 20},
            {40, 21},
            {60, 22},
            {80, 18}
        };

        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0, 6);
        }

        protected override bool Checksum(string pesel)
        {
            return pesel.Length == 11;
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            bool isLeapYear = YearValidator.IsLeapYear(year);

            return YearValidator.IsCorrect(year) && MonthValidator.IsCorrect(month) && DayValidator.IsCorrect(day, month, isLeapYear);
        }

        public override string GetNick()
        {
            return "Hipek";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (pesel != null && Checksum(pesel))
            {
                string date = CutOffDate(pesel);

                int month = int.Parse(date.Substring(2, 2));
                int difference = monthsDictionary[month / 20];
                month -= difference;

                int year = int.Parse(date.Substring(0, 2));
                int stulecie = stulecieDictionary[difference];
                year = int.Parse(stulecie.ToString() + year.ToString());

                int day = int.Parse(date.Substring(4, 2));

                return ValidateDate(year, month, day);
            }
            return false;
        }
    }
}
