﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Toci.TraininigLibrary.Developers.Mg.Inheritance.Common_interface_solution.Base;

namespace Toci.TraininigLibrary.Developers.Mg.Inheritance.Common_interface_solution
{
    public class MgCommonNonGenericSortedList<T> : MgCommonNonGenericSortedListBase<T>
    {
        public override List<T> GetAnagramSet(string anagramCandidate)
        {
            List<T> itemList = new List<T>();


            var anagramCandidateArray = anagramCandidate.ToUpper().ToArray();
            Array.Sort(anagramCandidateArray);
            bool isAnagram;

            foreach (var key in this.Keys)
            {

                var array = key.ToString().ToUpper().ToArray();

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

                if (isAnagram) itemList.Add((T)this[key]);

            }
            return itemList;
        }


        public override List<T> GetPalindromSet()
        {

            List<T> itemList = new List<T>();
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var key in this.Keys)
            {
                var reversedArray = key.ToString().Reverse().ToArray();

                foreach (var letter in reversedArray)
                {
                    stringBuilder.Append(letter);
                }

                if (stringBuilder.ToString().ToUpper() == key.ToString().ToUpper()) itemList.Add((T)this[key]);

                stringBuilder.Clear();
            }

            return itemList;
        }

        public override List<T> GetWildcardSet(string wildcard)
        {


            return null;
            // return this.Where(x => x.Key.Contains(wildcard)).Select(x => x.Value).ToList();

        }


    }
}
