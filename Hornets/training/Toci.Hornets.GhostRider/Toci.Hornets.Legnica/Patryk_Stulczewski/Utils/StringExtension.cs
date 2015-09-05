using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Toci.Hornets.Legnica.Patryk_Stulczewski.Utils
{
    public static class StringExtension
    {
        public static string Sort(this string str)
        {
            return new string(str.OrderBy(x => x).ToArray());
        }

        public static int SubstringToInt(this string str, int start, int lenght)
        {
            return int.Parse(str[start] == '0' ? str[start + 1].ToString() : str.Substring(start, lenght));
        }
    }
}

