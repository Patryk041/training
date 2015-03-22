using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Excercise
{
    public interface ITextOperationsSets
    {
        string GetNick();

        string[] GetPalindromsSet();

        string[] GetAnagramsSet(string anagram); // rarat trraa tarra

        string[] GetWildCardSet(string wildcard); // test, testfdsaf, testfdsgrw  - > tes te test testf
    }
}
