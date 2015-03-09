using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Toci.TraininigLibrary.Common.Base.Inheritance;

namespace Toci.TraininigLibrary.Developers.Mg.Inheritance.Simple_Inheritance
{
    public class MgStringDictionaryInheritance<T> : StringDictionary<T>
    {
      
        public override List<T> GetAnagramSet(string anagramCandidate)
        {
           List<T> itemList = new List<T>();
       
           
           var anagramCandidateArray = anagramCandidate.ToUpper().ToArray();
           Array.Sort(anagramCandidateArray);
            bool isAnagram;

            foreach (var key in this.Keys)
            {

                var array = key.ToUpper().ToArray();
                
               if(array.Length!=anagramCandidateArray.Length) continue;

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

                if(isAnagram) itemList.Add(this[key]);
         
            }
            return itemList;
        }


        public override List<T> GetPalindromSet()
        { 
         
            List<T> itemList = new List<T>();
            StringBuilder stringBuilder  = new StringBuilder();

            foreach (var key in this.Keys)
            {
                var reversedArray = key.Reverse().ToArray();
               
                foreach (var letter in reversedArray)
                {
                    stringBuilder.Append(letter);
                }

                if (stringBuilder.ToString().ToUpper() == key.ToUpper()) itemList.Add(this[key]);

                stringBuilder.Clear();
            }

            return itemList;
        }

        public override List<T> GetWildcardSet(string wildcard)
        {
            return this.Where(x => x.Key.ToUpper().Contains(wildcard.ToUpper())).Select(x => x.Value).ToList();
            // return this.Keys.Select(x => x).Where(x => x.ToUpper().Contains(wildcard.ToUpper())).ToList();
        }
    }
}
