namespace Toci.Hornets.Bytom.Szary.TrainingTwo.DateOperations
{
    public class Months
    {
        public static bool Month(int month)
        {
            return month % 20 < 13 && month > 0;
        }
    }
}