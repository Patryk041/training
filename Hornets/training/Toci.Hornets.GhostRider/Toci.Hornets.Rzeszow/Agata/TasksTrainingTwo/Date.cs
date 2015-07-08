using System;

namespace Toci.Hornets.Rzeszow.Agata.TasksTrainingTwo
{
    public class Date
    {
        public int year;
        public int month;
        public int day;

        public Date(string date)
        {
            year = Int32.Parse(date.Substring(0, 2));
            month = Int32.Parse(date.Substring(2, 2));
            day = Int32.Parse(date.Substring(4, 2));

            year += GetCentury(month);
            month = GetMonth(month);
        }

        private int GetCentury(int month)
        {
            if (0 < month && month < 13) return 1900;
            if (80 < month && month < 93) return 1800;
            if (20 < month && month < 33) return 2000;
            if (40 < month && month < 53) return 2100;
            if (60 < month && month < 73) return 2200;
            throw new Exception("Niepoprawny miesiąc w dacie");

            // 1-12 -> 1900
            // 81-92 -> 1800
            // 21-32 -> 2000
            // 41-52 -> 2100
            // 61-72 -> 2200
        }

        private int GetMonth(int month)
        {
            if (0 < month && month < 13) return month;
            if (80 < month && month < 93) return (month-80);
            if (20 < month && month < 33) return (month - 20);
            if (40 < month && month < 53) return (month - 40);
            if (60 < month && month < 73) return (month - 60);
            throw new Exception("Niepoprawny miesiąc w dacie");
        }
    }
}