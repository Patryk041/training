using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.TrainingThree.Inheritance
{
    class DictionaryInheritance<T> : Dictionary<string, T>
    {
        private Dictionary<string, T> test = new DictionaryInheritance<T>();

        public IEnumerable<T> GetPalindromsSet()
        {
            foreach (var item in this)
            {
                //item.Key
                yield return item.Value;
            }

            //return null;
        }
    }
}
