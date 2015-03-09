using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.Inheritance
{
    public static class ExtensionsByDysq
    {
        public static List<T> IsDysqAnagram<T>(this Dictionary<string,T> dysqDictionary, string anagramCandidate)//radar  raadr
        {
              bool isDysqAnagram;
            List<T> anagramList = new List<T>();
           
            var anagramCandidateArray = anagramCandidate.ToUpper().ToArray();
            Array.Sort(anagramCandidateArray);

            foreach (var key in dysqDictionary.Keys)
            { 
                var arrayOfkey = key.ToUpper().ToArray();
                Array.Sort(arrayOfkey);

                if (key.Length != anagramCandidateArray.Length)
                    continue;

                isDysqAnagram = true;

                for (int i = 0; i <= key.Length; i++)
                {
                    if (arrayOfkey[i] != anagramCandidateArray[i])
                         isDysqAnagram = false;
                    break;
                }
                if(isDysqAnagram) anagramList.Add(dysqDictionary[key]);
                
            }
            return anagramList;
        }
        

        public static List<T> IsDysqPalindrom<T>(this Dictionary<string,T> dysqDictionary, string palindromCandidate)// cyc radar aerrea
        {
            return (from key in dysqDictionary.Keys let reversedKey = key.Reverse().ToString() where reversedKey.ToUpper() == palindromCandidate.ToUpper() select dysqDictionary[key]).ToList();
        }


        public static List<T>IsDysqWildcard<T>(this Dictionary<string,T> dysqDictionary, string wildcard)// test*  :   testdsafda testewqrfqe, testgfe
        {
            List<T> wildCardList = new List<T>();

            foreach (var key in dysqDictionary.Keys)
            {
                if (key.ToUpper().StartsWith(wildcard.ToUpper()))
                {
                    wildCardList.Add(dysqDictionary[key]);
                }
            }
            return wildCardList;
        } 
    }
}
