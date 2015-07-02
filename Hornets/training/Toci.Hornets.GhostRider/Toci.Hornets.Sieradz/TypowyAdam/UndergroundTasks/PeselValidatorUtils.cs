namespace Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks
{
    public static class PeselValidatorUtils
    {
        public static bool ValidateYear(int year)
        {
            return true;
        }

        public static bool ValidateMonthAndDay(int month, int day)
        {
            return true;
        }

        public static int CalculateCheckSum(string sum)
        {
            int checkSum = 0;
            return checkSum;
        }
        public static bool CheckCheckSum(int checksum, int result)
        {
            return checksum == result;
        }
    }
}