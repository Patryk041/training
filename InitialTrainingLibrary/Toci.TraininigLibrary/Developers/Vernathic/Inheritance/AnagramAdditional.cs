using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Vernathic.Inheritance
{
    static class AnagramAdditional<T1, T2>
    {
        public static bool CompareDictionaries(Dictionary<T1, T2> dictionary1, Dictionary<T1, T2> dictionary2)
        {
            //dictionaries must have equal numbers of keys,
            //keys must be equal,
            //values for keys must be equal as well

            foreach (var item1 in dictionary1)
            {
                if (!dictionary2.ContainsKey(item1.Key))
                    return false;
                if (!dictionary2[item1.Key].Equals(item1.Value))
                    return false;
            }
            //get 1st key of dictionary1
            //check if dictionary2.ContainsKey (this from dictionary1)
                //if true: check if value of this key is equal value of this key in dictionary2
            
            //return true - if you check all of keys
            return true;
        }

        public static Dictionary<char, int> SplitToDictionary(string str)
        {
            //key - letter from string
            //value - amount of letter in the string
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            //for each letter in str 
            //if letter is one of keys in dictionary, value++
            for (int i = 0; i < str.Length; i++)
            {
                //check if dictionary contains letter
                if (!dictionary.ContainsKey(str[i])) dictionary.Add(str[i], 1);
                else dictionary[str[i]]++;
            }

            return dictionary;
        }
    }
}
