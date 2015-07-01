using System;
using System.Linq;
using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.StringComparator
{
    public class UCantTouchThisStringComparator : IStringComparator
    {
        public bool CompareTwoStrings(string s1, string s2)
        {
            return s1.ToCharArray().Where(Char.IsLetter).Count() ==
                   s2.ToCharArray().Where(Char.IsLetter).Count();
        }
    }
}