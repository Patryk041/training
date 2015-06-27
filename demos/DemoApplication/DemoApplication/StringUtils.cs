using System.Linq;

namespace DemoApplication
{
    public static class StringUtils
    {
        public static bool IsPalindrom(string palindromCandidate)
        {
            return palindromCandidate.ToCharArray().SequenceEqual(palindromCandidate.Reverse());
        }
    }
}