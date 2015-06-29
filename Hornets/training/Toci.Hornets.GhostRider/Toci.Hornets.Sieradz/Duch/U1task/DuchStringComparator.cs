using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks;
using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.Sieradz.Duch
{
    public class DuchStringComparator : IStringComparator
    {
        public bool CompareTwoStrings(string s1, string s2)
        {
            return s1.CmpWtf().Length == s2.CmpWtf().Length;
        }
    }
}
