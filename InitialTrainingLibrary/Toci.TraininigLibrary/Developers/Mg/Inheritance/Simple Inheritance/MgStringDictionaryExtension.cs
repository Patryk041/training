using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toci.TraininigLibrary.Developers.Mg.Inheritance.Simple_Inheritance
{
    public static class MgStringDictionaryExtension 
    {
       

        public static List<T> GetAnagramSetExtension<T>(this MgStringDictionaryInheritance<T> dictionary, string anagramCandidate)
        {
            List<T> itemList = new List<T>();


            var anagramCandidateArray = anagramCandidate.ToUpper().ToArray();
            Array.Sort(anagramCandidateArray);
            bool isAnagram;

            foreach (var key in dictionary.Keys)
            {

                var array = key.ToUpper().ToArray();

                if (array.Length != anagramCandidateArray.Length) continue;

                Array.Sort(array);
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

                if (isAnagram) itemList.Add(dictionary[key]);

            }
            return itemList;
        }


        public static List<T> GetPalindromSetExtension<T>(this MgStringDictionaryInheritance<T> dictionary)
        {
            List<T> itemList = new List<T>();
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var key in dictionary.Keys)
            {
                var reversedArray = key.Reverse().ToArray();

                foreach (var letter in reversedArray)
                {
                    stringBuilder.Append(letter);
                }

                if (stringBuilder.ToString().ToUpper() == key.ToUpper()) itemList.Add(dictionary[key]);

                stringBuilder.Clear();
            }

            return itemList;
        }

        public static List<T> GetWildcardSetExtension<T>(this MgStringDictionaryInheritance<T> dictionary, string wildcard)
        {
           // return dictionary.Keys.Select(x => x).Where(x => x.Contains(wildcard)).ToList();
            return dictionary.Where(x => x.Key.Contains(wildcard)).Select(x => x.Value).ToList();
        }
      
    }
}
