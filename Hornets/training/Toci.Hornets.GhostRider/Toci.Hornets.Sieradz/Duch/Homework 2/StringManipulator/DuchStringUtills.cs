using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Sieradz.Duch.Homework_2.StringManipulator
{
    static class DuchStringUtills
    {
        public static char[] OrderString(string s1)
        {
            var _s1 = s1.ToLower().ToArray();
            Array.Sort(_s1);
            return _s1;
        }
    }
}
