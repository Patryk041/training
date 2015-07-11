namespace Toci.Hornets.Kalisz.Amman.PeselValidator.Workers.DateValidation
{
    public class MonthValidator
    {
        public static int GetMonth(string date)
        {
            var yearString = date.Substring(2, 2);
            var result = int.Parse(yearString);
            result %= 20;
            return result;
        }
        public static bool IsValid(int month)
        {
            return month >= 1 && month <= 12;
        }
    }
}