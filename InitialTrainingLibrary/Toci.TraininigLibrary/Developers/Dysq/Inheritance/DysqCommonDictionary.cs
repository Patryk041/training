using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Dysq.Inheritance.Base;

namespace Toci.TraininigLibrary.Developers.Dysq.Inheritance
{
    public class DysqCommonDictionary<T> : DysqCommonDictionaryBase<T>
    {
        public override List<T> GetAnagramSet(string anagramCandidate)
        {
            bool isDysqAnagram;
            List<T> anagramList = new List<T>();
           
            var anagramCandidateArray = anagramCandidate.ToUpper().ToArray();
            Array.Sort(anagramCandidateArray);

            foreach (var key in this.Keys)
            { 
                var arrayOfkey = key.ToUpper().ToArray();
                Array.Sort(arrayOfkey);

                if (key.Length != anagramCandidateArray.Length)
                    continue;

                isDysqAnagram = true;

                for (int i = 0; i < key.Length; i++)
                {
                    if (arrayOfkey[i] != anagramCandidateArray[i])
                    {isDysqAnagram = false;
                    break;}
                }
                if(isDysqAnagram) anagramList.Add(this[key]);
                
            }
            return anagramList;
        }

        public override List<T> GetPalindromSet()
        {
            List<T> palindromList = new List<T>();

            bool isPalindrom;
            foreach (var key in this.Keys)
            {
                isPalindrom = false;
                var keyCharArray = key.ToArray();
                var reversedSequenceOfKeyChars = key.ToArray();
                Array.Reverse(reversedSequenceOfKeyChars);

                var a =keyCharArray.ToString();
                var b = reversedSequenceOfKeyChars.ToString();
                
                for (int i = 0; i < keyCharArray.Count(); i++)
                {
                    if (keyCharArray[i] != reversedSequenceOfKeyChars[i])
                        break;
                    isPalindrom = true;

                }
                if(isPalindrom)
               palindromList.Add(this[key]);
            }

            return palindromList;
        }

        public override List<T> GetWildcardSet(string wildcard)
        {
            List<T> wildCardList = new List<T>();

            foreach (var key in this.Keys)
            {
                if (key.ToUpper().StartsWith(wildcard.ToUpper()))
                {
                    wildCardList.Add(this[key]);
                }
            }
            return wildCardList;
        }
    }
}
