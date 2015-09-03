namespace Toci.Hornets.Legnica.Bombel.PeselValidator.DateValidator
{
    public class DayValidator
    {
        private const int Min = 1;
        private const int ShortFeb = 28;
        private const int LongFeb = 29;
        private const int ShortMonth = 30;
        private const int LongMonth = 31;

        public static bool ValidDay(int day, int month, int year)
        {
            return (day >= Min && day <= DaysInMonth(year, month));
        }

        private static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }
        private static int DaysInMonth(int year, int month)
        {
            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    return ShortMonth;
                case 2:
                    return IsLeapYear(year) ? LongFeb : ShortFeb;
            }
            return LongMonth;
        }
    }
}