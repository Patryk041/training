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
        public override List<T> GetAnagramSet(string anagramCandidate)    //radar  raadr
        {
            List<T> anagramSet = new List<T>();
            foreach (var item in this)
            {
                if (item.Key == anagramCandidate)
                {
                    anagramSet.Add(item.Value);
                }
            }
            return anagramSet;
            //TODO:: make it working with anagram case, not only comparison
            //compare dictionary's keys with anagramCandidate
            //return list of all dictionary values  of the word anagramCandidate
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
            //throw new NotImplementedException();
        }

        private static string ReverseKey(string key)
        {
            var reversedKey = new StringBuilder();
            for (var i = key.Length-1; i > -1; i--)
            {
                reversedKey.Append(key[i]);
            }
            return reversedKey.ToString();
            //throw new NotImplementedException();
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
            //TODO:: ensure it works
            return wildcardSet;
            //throw new NotImplementedException();
        }
    }
}
