using System;
using System.Collections.Generic;

namespace Toci.Hornets.Rzeszow.KubaT.TrainingTwo.PeselValidator
{
    public class DateAdministrator
    {
        public static string GetDay(string pesel)
        {
            return pesel.Substring(4, 2);
        }

        public static string GetYearAndMonth (string pesel)
        {
            var year = pesel.Substring(0, 2);
            var month = pesel.Substring(2, 2);
            int yearInt = Convert.ToInt32(year);
            int monthInt = Convert.ToInt32(month);
            var decodeDate = new List<int> {80, 1800, 60, 2200, 40, 2100, 20, 2000};
            for (var index = decodeDate.Count - 1; index >= 0; index--)
            {
                if (monthInt <= 12)
                {
                    yearInt += 1900;
                    break;
                }
                if (monthInt > index - 1)
                {
                    yearInt += decodeDate[index];
                    monthInt -= decodeDate[index - 1];
                }    
            }
            year = Convert.ToString(yearInt);
            month = Convert.ToString(monthInt);
            return month + year;
        }

        public static string GetDate(string pesel)
        {
            var day = GetDay(pesel);
            var monthAndYear = GetYearAndMonth(pesel);
            var date = day + monthAndYear;
            return date;
        }

        public static bool IsDateCorrect(int year, int month, int day)
        {
            if (month <= 0 || month > 12)
            {
                return false;
            }
            return true;
        }
    }
}