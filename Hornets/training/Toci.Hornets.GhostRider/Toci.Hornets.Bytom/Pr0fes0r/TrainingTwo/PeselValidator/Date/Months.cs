namespace Toci.Hornets.Bytom.Pr0fes0r.TrainingTwo.PeselValidator.Date
{
    public class Months
    {
        public static bool Month(int month)
        {
            if (month%20 < 13 && month > 0)
            {
                return true;
            }
            return false;
        }
    }
}