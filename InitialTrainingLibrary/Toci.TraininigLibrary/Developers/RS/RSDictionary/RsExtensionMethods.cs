using System.Collections.Generic;
using System.Linq;

namespace Toci.TraininigLibrary.Developers.RS.RSDictionary
{
    public static class RsExtensionMethods
    {
        public static List<string> GetAnagramSet(this Dictionary<string, string> dictionary, string anagramCandidate)
        {
            List<string> results = new List<string>();

            foreach (var dictionaryMember in dictionary)
            {
                var anagramCharArray = anagramCandidate.ToLower().ToCharArray().OrderBy(s => s);
                var dictionaryMemberKeyCharArray = dictionaryMember.Key.ToLower().ToCharArray().OrderBy(s => s);

                if (anagramCharArray.SequenceEqual(dictionaryMemberKeyCharArray))
                {
                    results.Add(dictionaryMember.Value);
                }
            }
            return results;
        }

        public static List<string> GetPalindromSet(this Dictionary<string, string> dictionary)
        {
            List<string> results = new List<string>();

            foreach (var dictionaryMember in dictionary)
            {
                var key = dictionaryMember.Key.ToLower().ToCharArray();
                var reverseKey = key.Reverse();

                if (key.SequenceEqual(reverseKey))
                {
                    results.Add(dictionaryMember.Value);
                }
            }
            return results;
        }

        public static List<string> GetWildcardSet(this Dictionary<string, string> dictionary, string wildcard)
        {
            int wildcardSize = wildcard.Length;
            List<string> results = new List<string>();

            foreach (var dictionaryMember in dictionary)
            {
                if (dictionaryMember.Key.Length < wildcardSize)
                {
                    continue;
                }

                string subStringKey = dictionaryMember.Key.Substring(0, wildcardSize);

                if (subStringKey == wildcard)
                {
                    results.Add(dictionaryMember.Value);
                }
            }
            return results;
        }
    }
}
