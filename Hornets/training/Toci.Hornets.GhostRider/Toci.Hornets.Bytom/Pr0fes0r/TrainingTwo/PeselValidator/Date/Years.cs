namespace Toci.Hornets.Bytom.Pr0fes0r.TrainingTwo.PeselValidator.Date
{
    public class Years
    {
        public static bool Year(int year)
        {
            if (year > 1799 && year < 2300)
            {
                return true;
            }

            return false;
        }
    }
}