using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Base.Inheritance;

namespace Toci.TraininigLibrary.Developers.Mg.Inheritance
{
    public class MgStringDictionary<T> : StringDictionary<string>
    {
        private List<string> itemList;
      

        public override List<string> GetAnagramSet(string anagramCandidate)
        {
           itemList = new List<string>();
       
           
           var anagramCandidateArray = anagramCandidate.ToArray();
           Array.Sort(anagramCandidateArray);
            bool isAnagram;

            foreach (var key in this.Keys)
            {

                var array = key.ToArray();
                Array.Sort(array);

               if(array.Length!=anagramCandidateArray.Length) continue;

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

                if(isAnagram) itemList.Add(key);
         
            }
            return itemList;
        }

      
        public override List<string> GetPalindromSet()
        { 
         
            itemList = new List<string>();
            StringBuilder stringBuilder  = new StringBuilder();

            foreach (var key in this.Keys)
            {
                var reversedArray = key.Reverse().ToArray();

                var reversedString = reversedArray.ToString();
                foreach (var letter in reversedArray)
                {
                    stringBuilder.Append(letter);
                }

                if (stringBuilder.ToString() == key) itemList.Add(key);

                stringBuilder.Clear();
            }

            return itemList;
        }

        public override List<string> GetWildcardSet(string wildcard)
        {
           

            return this.Keys.Select(x => x).Where(x => x.Contains(wildcard)).ToList();
        }
    }
}
