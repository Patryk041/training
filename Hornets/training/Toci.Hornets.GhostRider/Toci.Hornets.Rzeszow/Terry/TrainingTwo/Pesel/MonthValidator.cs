namespace Toci.Hornets.Rzeszow.Terry.TrainingTwo.Pesel
{
    public static class MonthValidator
    {
        private const int MaximumMonth = 12;
        private const int MinimumMonth = 1;

        public static bool ValidateMonth(PeselDate date)
        {
            date.Century = (MinimumMonth <= date.Month && date.Month <= MaximumMonth) ? 19 : CheckCentury(date);

            return MinimumMonth <= date.Month && date.Month <= MaximumMonth;
        }

        private static int CheckCentury(PeselDate date)
        {
            int iterationCount;

            for (iterationCount = 0; iterationCount <= 4; iterationCount++)
            {
                date.Month -= 20;
                if (MinimumMonth <= date.Month && date.Month <= MaximumMonth) break;
            }

            switch (iterationCount)
            {
                case 0:
                    return 20;
                case 1:
                    return 21;
                case 2:
                    return 22;
                case 3:
                    return 18;
                default:
                    return 19;
            }
        }
    }
}