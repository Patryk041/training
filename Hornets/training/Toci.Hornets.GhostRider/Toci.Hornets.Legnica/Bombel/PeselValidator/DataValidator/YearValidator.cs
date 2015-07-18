namespace Toci.Hornets.Legnica.Bombel.PeselValidator.DateValidator
{
    public class YearValidator
    {
        private const int Min = 1800;
        private const int Max = 2299;

        public static bool ValidYear(int year)
        {
            return (year >= Min && year <= Max);
        }

    }
}