using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Base.Inheritance;
using Toci.TraininigLibrary.Developers.Robson.RobsonExtendedDictionary;

namespace Toci.TraininigLibrary.Developers.Robson.RobsonsDictionaryInheritance
{
    public class RobsonsDictionary : StringDictionary<ExampleClass>
    {
        public override List<ExampleClass> GetAnagramSet(string anagramCandidate)
        {
            List<ExampleClass> list = new List<ExampleClass>();

            foreach(var item in this)
            {
                var firstString = item.Key.ToArray().Where(c => c >= 'a' && c <= 'z');
                var secondString = anagramCandidate.ToArray().Where(c => c >= 'a' && c <= 'z');

                if(firstString.OrderBy(c => c).SequenceEqual(secondString.OrderBy(c => c)))
                {
                    list.Add(item.Value);
                }
            }
            return list;
        }
        
        public override List<ExampleClass> GetPalindromSet()
        {
            List<ExampleClass> list = new List<ExampleClass>();

            foreach(var item in this)
            {
                string firstString = item.Key.ToString();
                StringBuilder secondString = new StringBuilder(firstString.Length);
                for (int i = firstString.Length - 1; i >= 0; i-- )
                {
                    secondString.Append(firstString[i]);
                }

                    if (firstString == secondString.ToString())
                    {
                        list.Add(item.Value);
                    }
            }
            
            
            return list;
        }

        public override List<ExampleClass> GetWildcardSet(string wildcard)
        {
            List<ExampleClass> list = new List<ExampleClass>();

            foreach (var item in this)
            {
                if(item.Key.ToString().StartsWith(wildcard))
                {
                    list.Add(item.Value);
                }
            }

            return list;
        }
    }
}
