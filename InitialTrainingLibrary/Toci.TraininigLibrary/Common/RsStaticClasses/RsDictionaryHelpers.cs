using System.Linq;

namespace Toci.TraininigLibrary.Common.RsStaticClasses
{
    public static class RsDictionaryHelpers
    {
        public static bool IsAnagram(string anagramCandidate, string keyValue)
        {
            var anagramCharArray = anagramCandidate.ToLower().ToCharArray().OrderBy(s => s);
            var dictionaryMemberKeyCharArray = keyValue.ToLower().ToCharArray().OrderBy(s => s);

            if (anagramCharArray.SequenceEqual(dictionaryMemberKeyCharArray))
            {
                return true;
            }
            return false;
        }

        public static bool IsPalindrom(string palindromCandidate)
        {
            var key = palindromCandidate.ToLower().ToCharArray();
            var reverseKey = key.Reverse();

            if (key.SequenceEqual(reverseKey))
            {
                return true;
            }
            return false;
        }

        public static bool ContainsWildCard(string wildCard, string keyValue)
        {
            if (keyValue.Length < wildCard.Length)
            {
                return false;
            }

            string subStringKey = keyValue.Substring(0, wildCard.Length);

            if (subStringKey == wildCard)
            {
                return true;
            }
            return false;
        }
    }
}
