using System.Collections.Generic;
using System.Linq;
using Toci.TraininigLibrary.Common.RsStaticClasses;

namespace Toci.TraininigLibrary.Developers.RS.RSDictionary
{
    public static class RsExtensionMethods
    {
        public static List<string> GetAnagramSet(this Dictionary<string, string> dictionary, string anagramCandidate)
        {
            // OLD VERSION
//            List<string> results = new List<string>();
//
//            foreach (var dictionaryMember in dictionary)
//            {
//                if (RsDictionaryHelpers.IsAnagram(anagramCandidate, dictionaryMember.Key))
//                {
//                    results.Add(dictionaryMember.Value);
//                }
//            }
//            return results;

            // NEW VERSION
            var results = RsDictionaryHelpers.RsDictionaryHelperInvoke(RsDictionaryHelpers.IsAnagram, dictionary, anagramCandidate).ToList();
            return results.OfType<string>().ToList();
        }

        public static List<string> GetPalindromSet(this Dictionary<string, string> dictionary)
        {
            // OLD VERSION
//            List<string> results = new List<string>();
//
//            foreach (var dictionaryMember in dictionary)
//            {
//                if (RsDictionaryHelpers.IsPalindrom(null, dictionaryMember.Key))
//                {
//                    results.Add(dictionaryMember.Value);
//                }
//            }
//            return results;

            // NEW VERSION
            var results = RsDictionaryHelpers.RsDictionaryHelperInvoke((param1, param2) => RsDictionaryHelpers.IsPalindrom(param1), dictionary, null).ToList();
            return results.OfType<string>().ToList();
        }

        public static List<string> GetWildcardSet(this Dictionary<string, string> dictionary, string wildcard)
        {
            // OLD VERSION
//            List<string> results = new List<string>();
//
//            foreach (var dictionaryMember in dictionary)
//            {
//                if (RsDictionaryHelpers.ContainsWildCard(wildcard, dictionaryMember.Key))
//                {
//                    results.Add(dictionaryMember.Value);
//                }
//            }
//            return results;

            // NEW VERSION
            var results = RsDictionaryHelpers.RsDictionaryHelperInvoke(RsDictionaryHelpers.ContainsWildCard, dictionary, wildcard).ToList();
            return results.OfType<string>().ToList();
        }
    }
}
