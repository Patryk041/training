using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.denio.PalindromAnagramWildcard
{
    class TextOperations : ITextOperationsSets
    {
        public string GetNick()
        {
            return "denio";
        }

        public string[] GetPalindromsSet()
        {
            denioFilterSets sets = new denioFilterSets();
            //var result = sets.GetPalindroms(new[] { "radar", "fdsabhfda", "cyc", "fxafdagdsgsdf", "agga" });
            var result = sets.GetPalindroms(new List<string>() { "radar", "fdsabhfda", "cyc", "fxafdagdsgsdf", "agga" });
            return result;
        }

        public string[] GetAnagramsSet(string anagram)
        {
            Anagram test = new Anagram();
            var results = test.tAnagram("Mother In Law", "The moral win");
            return results;
        }

        public string[] GetWildCardSet(string wildcard)
        {
            Wildcard wild = new Wildcard();
            var result = wild.GetWildcard("radar",new List<string>() {"radarowo", "radarnia", "vjcaJnxjsuxsj", "radarynka"});
            return result;
        }
    }
}
