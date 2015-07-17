using System.Linq;

namespace Toci.Hornets.Legnica.Amman.StringManipulator.Workers
{
    public class Anagram
    {
        static public bool IsAnagram(string big, string small)
        {
            foreach (var letter in big)
            {
                if (big.Count(x => x == letter)!=small.Count(x => x == letter))
                return false;
            }
            return big.Length == small.Length && StringElement.IsElement(big, small) && StringElement.IsElement(small, big); 
        }

         
    }
}