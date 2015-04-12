using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.denio.PalindromAnagramWildcard
{
    public class denioFilterSets
    {

        public List<string> GetPalindrom(List<string> setp, Func<string, bool> palindromItem)
        {
            return setp.Where(item => palindromItem(item)).ToList();
        }


        public string[] GetPalindroms(List<string> palindromCandidatesList)
        {

            var wynik = GetPalindrom(palindromCandidatesList,
                (inString) => inString.ToCharArray().SequenceEqual(inString.Reverse())).ToArray();
            return wynik;
        }
    }
}
