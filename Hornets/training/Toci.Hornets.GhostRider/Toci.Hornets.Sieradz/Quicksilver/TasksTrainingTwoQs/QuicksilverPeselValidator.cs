using System;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Sieradz.Quicksilver.TasksTrainingTwoQs
{
    public class QuicksilverPeselValidator : PeselValidator
    {

        public int[] multiplyBy = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
        public int[] daysOfMonthsShorter = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}; //365

       // public bool isYearLong(int year)
       // {
        //    return (year % 4 == 0 && (year % 100 != 0) || (year % 400 == 0));
       // }

        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0, 6);
        }

        protected override bool Checksum(string pesel)
        {
            int[] peselArray = pesel.Select(c => int.Parse(c.ToString())).ToArray();
            int ctrl = 0;
            for (int i = 0; i < 10; i++)
            {
              int numeho = peselArray[i]*multiplyBy[i];
                ctrl += numeho;
            }
            ctrl %= 10;
            ctrl = 10 - ctrl;
            ctrl %= 10;
            if (ctrl == peselArray[10]) return true;
            return false;
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            if (month > 80 && month < 93)
            {
                year += 1800;
                month -= 80;
            }
            else if (month > 0 && month < 13) year += 1900;
            else if (month > 20 && month < 33)
            {
                year += 2000;
                month -= 20;
            }
            else if (month > 40 && month < 53)
            {
                year += 2100;
                month -= 40;
            }
            else if (month > 60 && month < 73)
            {
                year += 2200;
                month -= 60;
            }

            if (year < 1800 || year > 2299) return false;
            if (month < 1 || month > 12) return false;
            
            for (int i =1; i < 13; i++)
            {
                if (month == i) return daysOfMonthsShorter[i] == day;
                //if (month == 2 && isYearLong(year) && day == 29)
                   // return true;
            }
            return true;
        }

        public override string GetNick()
        {
            return "Quicksilver";
        }

        public override bool IsPeselValid(string pesel)
        {
            string dateSubstring = CutOffDate(pesel);
            int year = Convert.ToInt32(dateSubstring.Substring(0, 2));
            int month = Convert.ToInt32(dateSubstring.Substring(2, 2));
            int day = Convert.ToInt32(dateSubstring.Substring(4, 2));
            if (ValidateDate(year, month, day) && Checksum(pesel)) return true;
            return false;

        }
    }
}