using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Mes.TextUtils
{
    public class Wildcards : FilterList
    {
        public Wildcards(string[] wildcardCandidates) : base(wildcardCandidates) { }

        private string pattern;

        public void SetPattern(string pattern)
        {
            this.pattern = pattern;
        }

        public override bool CheckCandidate(string candidate)
        {
            if (candidate.Length < pattern.Length)
                return false;

            if (candidate.Substring(0, pattern.Length) == pattern)
                return true;
            else
                return false;
        }
    }
}
