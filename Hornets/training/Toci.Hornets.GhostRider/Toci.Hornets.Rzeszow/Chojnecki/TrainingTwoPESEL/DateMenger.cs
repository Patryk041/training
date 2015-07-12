using System.Collections.Generic;
using System.Linq;

namespace Toci.Hornets.Rzeszow.Chojnecki.TrainingTwoPESEL
{
    public static class DateMenger
    {
        public static int CutMonth(int month)
        {
            return month%20;
        }

        private static int Date(int month)
        {
            var slownik = new Dictionary<int, int> {{80, 1900}, {60, 2220}, {40, 2100}, {20, 2000}, {0, 1900}};
            return (from key in slownik.Keys where key > month select slownik[key]).FirstOrDefault();
        }

        public static string GetYear(string pesel)
        {
            return (int.Parse(pesel.Substring(0, 2)) + Date(int.Parse(pesel.Substring(2, 2)))).ToString();
        }

        public static string GetMonth(string pesel)
        {
            var month = CutMonth(int.Parse(pesel.Substring(2, 2)));
            if (month < 10) return "0" + month;
            return month.ToString();
        }

        public static string GetDay(string pesel)
        {
            var day = int.Parse(pesel.Substring(4, 2));
            if (day < 10) return "0" + day;
            return day.ToString();
        }

        public static string GetDate(string pesel)
        {
            return GetDay(pesel) + GetMonth(pesel) + GetYear(pesel);
        }

        public static bool DayCheck(int year, int month, int day)
        {
            if (month > 12 || month == 0) return false;
            int[] daysInMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            if (year%4 == 0 && year%100 != 0 || year%400 == 0)
            {
                daysInMonth[1] = 29;
            }
            return day <= daysInMonth[month - 1];
        }
    }
}