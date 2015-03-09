using System.Collections.Generic;
using System.Linq;
using Toci.TraininigLibrary.Common.RsStaticClasses;

namespace Toci.TraininigLibrary.Developers.RS.RSDictionary
{
    public static class RsExtensionMethods
    {
        public static List<string> GetAnagramSet(this Dictionary<string, string> dictionary, string anagramCandidate)
        {
            List<string> results = new List<string>();

            foreach (var dictionaryMember in dictionary)
            {
                if (RsDictionaryHelpers.IsAnagram(anagramCandidate, dictionaryMember.Key))
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
                if (RsDictionaryHelpers.IsPalindrom(dictionaryMember.Key))
                {
                    results.Add(dictionaryMember.Value);
                }
            }
            return results;
        }

        public static List<string> GetWildcardSet(this Dictionary<string, string> dictionary, string wildcard)
        {
            List<string> results = new List<string>();

            foreach (var dictionaryMember in dictionary)
            {
                if (RsDictionaryHelpers.ContainsWildCard(wildcard, dictionaryMember.Key))
                {
                    results.Add(dictionaryMember.Value);
                }
            }
            return results;
        }
    }
}
