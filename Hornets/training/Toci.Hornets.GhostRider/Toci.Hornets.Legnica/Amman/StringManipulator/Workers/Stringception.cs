namespace Toci.Hornets.Legnica.Amman.StringManipulator.Workers
{
    public class Stringception
    {


        public static bool IsStringcepted(string big, string small)
        {
            return big == small || big.Contains(small);
        }
    }
}