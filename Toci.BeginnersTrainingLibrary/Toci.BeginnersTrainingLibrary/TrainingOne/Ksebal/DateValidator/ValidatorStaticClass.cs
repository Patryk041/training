namespace Toci.BeginnersTrainingLibrary.TrainingOne.Ksebal.DateValidator
{

    public static class ValidatorStaticClass
    {
        private static int[] miesiace = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        private const int MaxMonth = 13;
        private const int MinMonth = 1;


        public static bool IsLeapYear(int year)
        {
            if ((year%4 == 0 && year%100 != 0) || year%400 == 0)
                return true;
            return false;
        }

        public static bool ValidateDate(int year, int month, int day)
        {
            if (month < MaxMonth && month>=MinMonth&&
                (day <= miesiace[month - 1] || (IsLeapYear(year) && month == 2 && miesiace[month - 1] + 1 <= day)))
            {
                return true;
            }
            else return false;
        }


    }
}
