using System.Linq;

namespace Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks
{
    public static class PeselValidatorUtils
    {
        public static bool IsDayValid(int year, int month, int day)
        {
            int[] monthDays = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            if (day <= monthDays[month - 1] && day > 0)
                return true;
            if (month == 2 && IsLeapYear(year) && day == 29)
                return true;
            return false;
        }

        private static bool IsLeapYear(int year)
        {
            if (year%4 == 0 && (year%100 != 0) || (year%400 == 0))
                return true;
            return false;
        }

        public static bool CheckCheckSum(string pesel)
        {
            int checkSum = 0;
            int[] vages = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
            for (int i = 0; i < vages.Length; i++)
            {
                int test = pesel[i];
                checkSum += (vages[i]*(pesel[i]-48));
            }
            if (checkSum%10 != 0)
            {
                if ((10 - checkSum%10) == (pesel.Last()-48)) return true;
                return false;
            }
            if (checkSum%10 == 0 && (pesel.Last()-48) == 0) return true;
            return false;

        }
    }
}