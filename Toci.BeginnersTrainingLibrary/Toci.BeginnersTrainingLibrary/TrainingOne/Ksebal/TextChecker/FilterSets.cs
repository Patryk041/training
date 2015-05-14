using System.Collections.Generic;

//using KursBeginersMe.DatevalidatorHusar;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Ksebal.TextChecker

{

    public class FilterSets : ITextOPerationsSets

    {
        private string[] _candidateArray;

        public FilterSets(string[] tab)
        {
            _candidateArray = tab;
        }

        public string[] GetPalindromSet()
        {
            List<string> list = new List<string>();
            foreach (var str in _candidateArray)
            {
                if (TextUtils.IsPalindrom(str))
                    list.Add(str);
            }
            return list.ToArray();
        }

        public string GetNick()
        {
            return "Ksebal";
        }

        
        public string[] GetAnagramSet(string anagram)
        {
            List<string> list = new List<string>();
            foreach (var str in _candidateArray)
            {
                if (TextUtils.IsAnagram(anagram, str))
                    list.Add(str);
            }
            return list.ToArray();
        }




        public string[] GetWildCardSet(string wildcard)
        {
            List<string> list = new List<string>();
            foreach (var str in _candidateArray)
            {
                if (TextUtils.IsWildCard(wildcard, str))
                    list.Add(str);
            }
            return list.ToArray();
        }
    }


}


