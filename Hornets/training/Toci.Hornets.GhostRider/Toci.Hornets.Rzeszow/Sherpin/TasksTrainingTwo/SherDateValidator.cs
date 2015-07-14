using System;

namespace Toci.Hornets.Rzeszow.Sherpin.TasksTrainingTwo
{
    public class SherDateValidator
    {
        public int year;
        public int month;
        public int day;

        public SherDateValidator(string date)
        {
            year = Int32.Parse(date.Substring(0, 2));
            month = Int32.Parse(date.Substring(2, 2));
            day = Int32.Parse(date.Substring(4, 2));

            year += GetCentury(month);
            month = GetMonth(month);
        }
        private int GetMonth(int month)
        {
            if (0 < month && month < 13) return month;
            else if (80 < month && month < 93) return (month - 80);
            else if (20 < month && month < 33) return (month - 20);
            else if (40 < month && month < 53) return (month - 40);
            else if (60 < month && month < 73) return (month - 60);
            throw new Exception("Month is incorrect");
        }
        private int GetCentury(int month)
        {
            if (0 < month && month < 13) return 1900;
            else if (80 < month && month < 93) return 1800;
            else if (20 < month && month < 33) return 2000;
            else if (40 < month && month < 53) return 2100;
            else if (60 < month && month < 73) return 2200;
            throw new Exception("Month is incorrect");
        }
    }
}