using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Common.Utils
{
    public static class WarriorStringUtilities
    {
        public static bool WarriorIsAnagram(this string anagramTest, string anagramCandidate)
        {
            var anagramCandidateArray = anagramCandidate.ToUpper().ToArray();
            var anagramTestArray = anagramTest.ToUpper().ToArray();
            Array.Sort(anagramCandidateArray);
            Array.Sort(anagramTestArray);

            return anagramCandidateArray.SequenceEqual(anagramTestArray);
        }
    }
}
