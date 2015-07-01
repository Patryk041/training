namespace Toci.Hornets.Opole.Startup.TrainingOne.Zielu
{
    public static class ZieluDateValidation
    {
        const int LongMonth = 31;
        const int ShortMonth = 30;
        const int FebruaryMonth = 28;
        const int LowerInvalidMonth = 0;

        private static readonly int[] Months = new[]
        {
            LongMonth,
            FebruaryMonth,
            LongMonth,
            ShortMonth,
            LongMonth,
            ShortMonth,
            LongMonth,
            LongMonth,
            ShortMonth,
            LongMonth,
            ShortMonth,
            LongMonth
        };

        public static bool IsDayValid(int year, int month, int day)
        {
            if(IsMonthValid(month))
                return day>LowerInvalidMonth && day<MonthLenght(year,month);
            return false;
        }

        public static bool IsMonthValid(int month)
        {
            return month>0 && month<13;
        }

        public static int MonthLenght(int year,int month)
        {
            if (IsLeapYear(year) && month == 2)
                return 29;
            return Months[month+1];
        }

        public static bool IsLeapYear(int year)
        {
            return year%4==0 && year%100!=0 && year%400!=0;
        }

        public static bool IsDateValid(int year, int month, int day)
        {
            return IsMonthValid(year) && IsDayValid(year, month, day);
        }
    }
}
