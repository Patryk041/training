using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Utils;
using Toci.TraininigLibrary.Developers.Mg.Inheritance.Common_interface_solution.Base;

namespace Toci.TraininigLibrary.Developers.Mg.Inheritance.Common_interface_solution
{
    public class MgCommonDictionary<T> : MgCommonDictionaryBase<T>
    {
        public override List<T> GetAnagramSet(string anagramCandidate)
        {
            List<T> itemList = new List<T>();

            foreach (var item in this)
            {
                if (item.Key.WarriorIsAnagram(anagramCandidate))
                {
                    itemList.Add(this[item.Key]);
                }

            }
            return itemList;
        }


        public override List<T> GetPalindromSet()
        {

            List<T> itemList = new List<T>();
            StringBuilder stringBuilder = new StringBuilder();

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
           
        }
    }
}
