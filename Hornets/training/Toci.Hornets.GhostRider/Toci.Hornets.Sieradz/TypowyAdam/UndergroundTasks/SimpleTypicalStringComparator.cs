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
        private int s1LetterAmount, s2LetterAmount;
        public bool CompareTwoStrings(string s1, string s2)
        {

            s1.ToLower();
            s2.ToLower();
            char[] s1Array = s1.ToCharArray();
            char[] s2Array = s2.ToCharArray();
            foreach (var character in s1Array)
            {
                if (character >= 'a' && character <= 'z') s1LetterAmount++;
            }

            foreach (var character in s2Array)
            {
                if (character >= 'a' && character <= 'z') s2LetterAmount++;
            }
            
            return s1LetterAmount == s2LetterAmount;
            //return s1.Where(char.IsLetter).Count() == s2.Where(char.IsLetter).Count();
        }
    }
}
