using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Base.Inheritance;

namespace Toci.TraininigLibrary.Developers.Mg.Inheritance
{
    public static class MgStringDictionaryExtension 
    {
        private static List<string> itemList;

        public static List<string> GetAnagramSetExtension( this MgStringDictionaryInheritance dictionary , string anagramCandidate)
        {
            itemList = new List<string>();


            var anagramCandidateArray = anagramCandidate.ToArray();
            Array.Sort(anagramCandidateArray);
            bool isAnagram;

            foreach (var key in dictionary.Keys)
            {

                var array = key.ToArray();
                Array.Sort(array);

                if (array.Length != anagramCandidateArray.Length) continue;

                // isAnagram = !array.Where((t, i) => t != anagramCandidateArray[i]).Any();

                isAnagram = true;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != anagramCandidateArray[i])
                    {
                        isAnagram = false;
                        break;
                    }
                }

                if (isAnagram) itemList.Add(key);

            }
            return itemList;

        }


        public static List<string> GetPalindromSetExtension(this MgStringDictionaryInheritance dictionary)
        {
            itemList = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var key in dictionary.Keys)
            {
                var reversedArray = key.Reverse().ToArray();

                foreach (var letter in reversedArray)
                {
                    stringBuilder.Append(letter);
                }

                if (stringBuilder.ToString() == key) itemList.Add(key);

                stringBuilder.Clear();
            }

            return itemList;
        }

        public static List<string> GetWildcardSetExtension(this MgStringDictionaryInheritance dictionary, string wildcard)
        {
            return dictionary.Keys.Select(x => x).Where(x => x.Contains(wildcard)).ToList();
        }
      
    }
}
