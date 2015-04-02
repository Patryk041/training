using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.TextValidator
{
    class ZieluTexts : ITextOperationsSets
    {
        public string GetNick()
        {
            return "Zielu";
        }

        public string[] GetPalindromsSet()
        {
            throw new NotImplementedException();
        }

        public string[] GetAnagramsSet(string anagram)
        {
            throw new NotImplementedException();
        }

        public string[] GetWildCardSet(string wildcard)
        {
            throw new NotImplementedException();
        }
    }
}
