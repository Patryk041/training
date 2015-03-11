using System;
using System.Collections;
using System.Collections.Generic;
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

        public static bool IsPalindrom(string reverseKeyValue)
        {
            return reverseKeyValue.Reverse().SequenceEqual(reverseKeyValue.ToCharArray());
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

        public static IEnumerable<object> RsDictionaryHelperInvoke(Func<string, string, bool> myMethod, IDictionary myDictionary, string additionalCandidate)
        {
            List<object> results = new List<object>();

            foreach (DictionaryEntry dictionaryMember in myDictionary)
            {
                if (myMethod(dictionaryMember.Key.ToString(), additionalCandidate))
                {
                    results.Add(dictionaryMember.Value);
                }
            }   
            return results;
        }
    }
}
