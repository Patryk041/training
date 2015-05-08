using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;
using Toci.BeginnersTrainingLibrary.TrainingOne.Recha.TextOperations;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.coousey.TextUtils
{
    public class CoouseyTextUtils : ITextOperationsSets
    {
        private readonly string[] _strings;

        public CoouseyTextUtils(string[] strings)
        {
            _strings = strings;
        }

        public string[] GetPalindromsSet()
        {
            PalindromValidator palindromValidator = new PalindromValidator();
            return palindromValidator.GetValidExpresions(_strings, null);
        }

        public string[] GetAnagramsSet(string anagram)
        {
            AnagramValidator anagramValidator = new AnagramValidator();
            return anagramValidator.GetValidExpresions(_strings, anagram);
        }

        public string[] GetWildCardSet(string wildcard)
        {
            WildCardValidator wildCardValidator = new WildCardValidator();
            return wildCardValidator.GetValidExpresions(_strings, wildcard);
        }

        public string GetNick()
        {
            return "Coousey";
        }
    }
}
