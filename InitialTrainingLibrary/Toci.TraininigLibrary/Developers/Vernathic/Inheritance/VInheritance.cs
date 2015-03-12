using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Base.Inheritance;

namespace Toci.TraininigLibrary.Developers.Vernathic.Inheritance
{
    public class VInheritance<T> : StringDictionary<T>      //StringDictionary<T> : Dictionary<string, T>
    {
        public override List<T> GetAnagramSet(string anagramCandidate) //radar  raadr
        {
            List<T> anagramSet = new List<T>();

            //split anagramCandidate into dictionary anagramCandidateDictionary (letter by letter)
            //using SplitToDictionary method
            var splitedAnagramCandidate = AnagramAdditional<T, T>.SplitToDictionary(anagramCandidate);
            //TODO:: i get null here instead of dictionary<char, int>

            //for each item in VInheritance dictionary
            foreach (var item in this)
            {
                if (item.Key.Length == anagramCandidate.Length)
                {
                    var splitedItemKey = AnagramAdditional<T, T>.SplitToDictionary(item.Key);
                    //compare if splitedItemKey has the same keys and values as splitedAnagramCandidate
                    //get 1st element from splitedItemKey, check if splitedAnagramCandidate contains it with the same values
                    if (AnagramAdditional<char, int>.CompareDictionaries(splitedAnagramCandidate, splitedItemKey)) anagramSet.Add(item.Value);
                }
            }
            //DONE - check if the lenght of anagramCandidate equals length of item.Key (dictionary key)
            //if not: compare with next this.Key
            //if equals:
                //DONE - split item.Key
                    //compare splited item.Key with splited anagramCandidate (the keys and it's values must be the same)
                    //if equals: anagramSet.Add(item.Value)
                    //if not: go to next item.key
            return anagramSet;
        }

        public override List<T> GetPalindromSet()           // cyc radar aerrea
        {
            List<T> palindromSet = new List<T>();

            foreach (var item in this)
            {
                if (item.Key == ReverseKey(item.Key))
                {
                    palindromSet.Add(item.Value);
                }
            }
            return palindromSet;
        }

        private static string ReverseKey(string key)
        {
            var reversedKey = new StringBuilder();
            for (var i = key.Length-1; i > -1; i--)
            {
                reversedKey.Append(key[i]);
            }
            return reversedKey.ToString();
        }

        public override List<T> GetWildcardSet(string wildcard)     // test*  :   testdsafda testewqrfqe, testgfe
        {
            List<T> wildcardSet = new List<T>();

            foreach (var item in this)
            {
                if (item.Key.Contains(wildcard))
                {
                    wildcardSet.Add(item.Value);
                }
            }
            return wildcardSet;
        }
    }
}
