

using System.Linq;

namespace Toci.Hornets.Legnica.Amman.StringManipulator.Workers
{
    public class StringElement
    {
        static public bool IsElement(string big, string small)
        {
            
            /*
             * THIS IS MY CODE
             * if (Stringception.IsStringcepted(big, small)) return true;

            foreach (var letter in small)
            {
                if (!big.Contains(letter.ToString())) return false;
            }
            return true;
             * */

            //RESHARPER SUGGESTED TRANSFORMING INTO LINQ, KINDA HAVE IDEA WHAT IS HAPPENING BUT NOT 100%
            return Stringception.IsStringcepted(big, small) || small.All(letter => big.Contains(letter.ToString()));
        }
    }
}