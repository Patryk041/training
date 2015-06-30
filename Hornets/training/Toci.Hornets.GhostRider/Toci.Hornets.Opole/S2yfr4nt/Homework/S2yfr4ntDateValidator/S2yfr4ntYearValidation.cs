namespace Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntDateValidator
{
    public class S2yfr4ntYearValidation
    {
        private const int yearLimit = 0;

        public static bool ValidateYear(int year)
        {
            return year >= yearLimit;
        }

        public static bool isLeapYear(int year)
        {
            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
        } 
    }
}