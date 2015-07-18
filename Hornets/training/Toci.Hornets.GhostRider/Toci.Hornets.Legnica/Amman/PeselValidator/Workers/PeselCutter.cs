namespace Toci.Hornets.Legnica.Amman.PeselValidator.Workers
{
    public class PeselCutter
    {
        public static string Cut(string psl)
        {
            return psl.Length < 6 ? "ERROR - PESEL TOO SHORT FOR CUT" : psl.Substring(0, 6);
        }
    }
}