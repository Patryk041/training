namespace Toci.Hornets.Legnica.Bombel.PeselValidator.DateValidator
{
    public class MonthValidator
    {
        private const int Min = 1;
        private const int Max = 12;

        public static bool ValidMonth(int month)
        {
            return (month >= Min && month <= Max);
        }
    }
}