namespace Toci.Hornets.Kalisz.Amman.StringManipulator.Workers
{
    public class Anagram
    {
        static public bool IsAnagram(string big, string small)
        {
            return big.Length == small.Length && StringElement.IsElement(big, small); 
        }
    }
}