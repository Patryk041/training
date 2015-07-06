namespace Toci.Hornets.Rzeszow.Terry.TrainingTwo.Pesel
{
    public static class YearValidator
    {
        private const int MinimumYear = 1800;
        private const int MaximumYear = 2299;


        public static bool ValidateYear(PeselDate date)
        {
            date.Year += 1000*date.Century;
            date.IsLeapYear = IsLeapYear(date);
            return (MinimumYear <= date.Year && date.Year <= MaximumYear);
        }

        private static bool IsLeapYear(PeselDate date)
        {
            return date.Year % 4 == 0;
        }

    }
}