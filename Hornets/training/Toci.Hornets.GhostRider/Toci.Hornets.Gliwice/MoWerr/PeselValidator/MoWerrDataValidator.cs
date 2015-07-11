namespace Toci.Hornets.Gliwice.MoWerr.PeselValidator
{
    public class MoWerrPeselDateValidator
    {
        public static bool IsYearValid(int year)
        {
            return year >= 0 && year <= 99;
        }

        public static bool IsMonthValid(int month)
        {
            return !((month >= 13 && month <= 20) ||
                     (month >= 33 && month <= 80) ||
                     month >= 93 || month <= 0);
        }

        public static bool IsDateValid(int year, int month, int day)
        {
            if (!IsYearValid(year) || !IsMonthValid(month))
                return false;

            var realMonth = month%20;

            if ((day >= 1 && day <= 28) || (day == 30 && realMonth != 2))
                return true;

            if (day == 29)
            {
                if (realMonth != 2)
                    return true;

                var fullYear = GetFullYear(year, month);
                return IsLeapYear(fullYear);
            }

            if (day == 31)
            {
                return (realMonth%2 == 1 && realMonth <= 7) || (realMonth%2 == 0 && realMonth >= 8);
            }

            return false;
        }

        private static int GetFullYear(int year, int month)
        {
            if (month >= 0 && month <= 12)
                return 1900 + year;

            if (month >= 21 && month <= 32)
                return 2000 + year;

            if (month >= 81 && month <= 92)
                return 1800 + year;

            return -1;
        }

        private static bool IsLeapYear(int fullYear)
        {
            return ((fullYear%4 == 0 && fullYear%100 != 0) || fullYear%400 == 0);
        }
    }
}