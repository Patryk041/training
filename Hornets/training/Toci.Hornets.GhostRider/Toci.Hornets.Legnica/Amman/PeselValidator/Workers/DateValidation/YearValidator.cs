using System;

namespace Toci.Hornets.Kalisz.Amman.PeselValidator.Workers.DateValidation
{
    public class YearValidator
    {
        public static bool IsLeap(int year)
        {
            if (year%4 == 0 && year%100 != 0) return true;
            return year%400 == 0;
        }

        public static int GetYear(string date)
        {
            var coefficient = MonthValidator.GetMonth(date)/20;
            var year = int.Parse(date.Substring(0, 2));
            switch (coefficient)
            {
                case 0:
                    year += 1900;
                    break;
                case 1:
                    year += 2000;
                    break;
                case 2:
                    year += 2100;
                    break;
                case 3:
                    year += 2200;
                    break;
                case 4:
                    year += 1800;
                    break;

            }
            return year;
        }
        public static bool IsValid(int year)
        {
            return year >= 0;
        }
    }
}