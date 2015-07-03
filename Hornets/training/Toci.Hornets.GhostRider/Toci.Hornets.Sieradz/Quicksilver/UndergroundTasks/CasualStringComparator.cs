using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.Sieradz.Quicksilver.UndergroundTasks
{
    public class CasualStringComparator : IStringComparator
    {

        //private int abc;
        private int s1Count, s2Count;
        public bool CompareTwoStrings(string s1, string s2)
        {

            s1.ToLower();
            s2.ToLower();

            char[] s1Array = s1.ToCharArray();
            char[] s2Array = s2.ToCharArray();

            foreach (var abc in s1Array)
            {
                if (abc >= 'a' && abc <= 'z') s1Count++;
            }

            foreach (var abc in s2Array)
            {
                if (abc >= 'a' && abc <= 'z') s2Count++;  
            }



            return s1Count == s2Count;
        }
    }

}
