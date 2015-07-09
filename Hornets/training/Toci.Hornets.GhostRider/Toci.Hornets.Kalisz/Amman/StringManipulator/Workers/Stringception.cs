namespace Toci.Hornets.Kalisz.Amman.StringManipulator.Workers
{
    public class Stringception
    {


        public static bool IsStringcepted(string big, string small)
        {
            if (big == small) return true;
            return small != "" && big.Contains(small);
        }
    }
}