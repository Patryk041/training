using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks
{
    public static class U1Utils
    {
        public static char[] CmpWtf(this string a1)
        {
            const string abc = "abcdefghijklmnopqrstuvwxyz";
            return (from a in abc
                    join b in a1.ToLower() on a equals b
                    select a).ToArray();
        }
    }
}
