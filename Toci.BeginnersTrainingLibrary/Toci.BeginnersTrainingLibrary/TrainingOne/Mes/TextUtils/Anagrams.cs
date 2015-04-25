using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Mes.TextUtils
{
    public class Anagrams : FilterList
    {
        public Anagrams(string[] anagramCandidates) : base(anagramCandidates) { }

        private char[] anagramPattern;
        private string stringAnagramPattern;

        public void SetPattern(string pattern)
        {
            anagramPattern = pattern.ToCharArray();
            Array.Sort(anagramPattern);
            stringAnagramPattern = new string(anagramPattern);
        }

        public override bool CheckCandidate(string candidate)
        {
            char[] charCandidate = candidate.ToCharArray();
            Array.Sort(charCandidate);

            string stringCandidate = new string(charCandidate);

            if (stringCandidate == stringAnagramPattern)
                return true;
            else
                return false;

        }
    }
}
