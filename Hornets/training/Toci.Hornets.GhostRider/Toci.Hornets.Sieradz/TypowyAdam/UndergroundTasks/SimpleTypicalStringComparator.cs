using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks
{
    public class SimpleTypicalStringComparator : IStringComparator
    {

        public bool CompareTwoStrings(string s1, string s2)
        {

            return s1.Where(char.IsLetter).Count() == s2.Where(char.IsLetter).Count();
        }
    }
}
