using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingTwo.ExtensionMethods;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Lambdas
{
    public class DelegatesShowdown
    {
        private bool TestString(string whatever)
        {
            return true;
        }

        public List<string> GetWhateverSet(List<string> set, Func<string, bool> testMethod)
        {
            var result = new List<string>();

            foreach (var item in set)
            {
                if (testMethod(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public void Showdown(List<string> items)
        {
            GetWhateverSet(items, ExtMethodsShowdown.IsPalindrom);
        }

        public void LambdaShowdown(List<string> items)
        {
            //var result = GetWhateverSet(items, (inString) => inString.ToCharArray().SequenceEqual(inString.Reverse()));
            var result = GetWhateverSet(items, (inString) => ExtMethodsShowdown.IsPalindrom(inString));

            //items.Where((text) => ExtMethodsShowdown.IsPalindrom(text));
            items.Where((text) => text.StartsWith("radar"));

            //(dsaf,dsa,fdsa,fdsa,fsda,fdsa) => 
        }
    }
}
