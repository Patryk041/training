using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.R4D3K.Inheritance
{
    class R4D3KDictionary<T> : R4D3KDictionaryBase<T>
    {

        public override List<T> GetAnagramSet(string anagramCandidate)
        {
            var anagrams = new List<T>();
            bool isAnagram = false;
            ////////////////////////////////
            char[] alfabethic = anagramCandidate.ToCharArray();
            Array.Sort(alfabethic);
            ///////////////////////////////
            foreach (var item in this.Keys)
            {
                foreach (var letter in alfabethic)
                {
                    isAnagram = item.AsEnumerable().Contains(letter) && item.Length == alfabethic.Length ? true : false;
                }
                if (isAnagram == true)
                {
                    anagrams.Add(this[item]);
                    isAnagram = false;
                }
            }
            ///////////////////////////////
            return anagrams;

        }

        public override List<T> GetPalindromSet()
        {
            List<T> palindromList = new List<T>();
            bool isPalindrom = false;
            foreach (var key in this.Keys)
            {
                for (int i = 0; i < key.Count() - 1; i++)
                {
                    isPalindrom = key[i] == key[key.Count() - i] ? true : false;
                }
                if (isPalindrom == true)
                {
                    palindromList.Add(this[key]);
                    isPalindrom = false;
                }
            }

            return palindromList;
        }

        public override List<T> GetWildcardSet(string wildcard)
        {
            List<T> wildList = new List<T>();
            bool isWild = false;
            foreach (var key in this.Keys)
            {
                isWild = key.StartsWith(wildcard) ? true : false;
                if (isWild == true) wildList.Add(this[key]);
            }

            return wildList;
        }
    }

}
