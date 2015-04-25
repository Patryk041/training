using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Mes.TextUtils
{
    public class Palindroms : FilterList
    {

        public Palindroms(string[] candidateList) : base(candidateList)
        {
            
        }

        public override bool CheckCandidate(string candidate)
        {
            char[] arr = candidate.ToCharArray();
            Array.Reverse(arr);
            string reverse = new string(arr);
            return candidate == reverse;
        }
    }
}
