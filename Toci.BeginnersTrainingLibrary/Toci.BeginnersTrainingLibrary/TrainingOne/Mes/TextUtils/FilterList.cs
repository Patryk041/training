using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Mes.TextUtils
{
    public abstract class FilterList
    {
        protected string[] candidateList;

        public FilterList(string[] candidateList)
        {
            this.candidateList = candidateList;
        }

        public string[] GetFilteredList()
        {

            // dobre
            List<string> validCandidates = new List<string>();

            foreach (var word in candidateList)
            {
                if (CheckCandidate(word))
                    validCandidates.Add(word);
            }

            return validCandidates.ToArray();
        }

        public abstract bool CheckCandidate(string candidate);
    }
}
