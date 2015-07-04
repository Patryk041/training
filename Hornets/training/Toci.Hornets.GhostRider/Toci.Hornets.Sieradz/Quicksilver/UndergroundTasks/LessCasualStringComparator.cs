using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.Sieradz.Quicksilver.UndergroundTasks
{
    public class LessCasualStringComparator : IStringComparator
    {
        public bool CompareTwoStrings(string s1, string s2)
        {
           s1.ToLower();
           s2.ToLower();

            var s1Counter = s1.Count(x => x >= 'a' && x <= 'z');
            var s2Counter = s2.Count(y => y >= 'a' && y <= 'z');

            return s1Counter == s2Counter;
        }
    }
}
