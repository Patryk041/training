using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Legnica.Startup.LegnicaCode.Patryk_Stulczewski
{
    public static class StringExtensions
    {
        public static int SubstringToInt(this String str, int start, int lenght)
        {
            if(str[start] == '0')
                return int.Parse(str[start + 1].ToString());
            return int.Parse(str.Substring(start,lenght) );
        }
    }
}
