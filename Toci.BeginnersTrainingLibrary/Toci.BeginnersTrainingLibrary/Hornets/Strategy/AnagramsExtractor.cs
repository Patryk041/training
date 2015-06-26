using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.Hornets.Strategy
{
    public class AnagramsExtractor
    {
        public AnagramRecognizer AnagramRecognizer { get; set; }
        private Dictionary<int, List<string>> anagramsDictionary;

        public AnagramsExtractor(AnagramRecognizer anagramRecognizer)
        {
            this.AnagramRecognizer = anagramRecognizer;
        }

        public Dictionary<int, List<string>> ExtractAnagramsDictionary(List<string> candidatesList)
        {
            anagramsDictionary = new Dictionary<int, List<string>>();
            int countOfSublist = 0;
            List<string> currentAnagramsList = new List<string>();

            for (int i = 0; i < candidatesList.Count - 1; i++)
            {
                if (!currentAnagramsList.Contains(candidatesList[i]))
                {
                    countOfSublist = candidatesList.Count - (i + 1);
                    currentAnagramsList.AddRange(ExtractAnagramsList(candidatesList[i], candidatesList.GetRange(i + 1, countOfSublist)));
                }
            }
            return anagramsDictionary;
        }

        private List<String> ExtractAnagramsList(string pattern, List<string> candidateList)
        {
            var anagramsList = (from candidate in candidateList
                                where AnagramRecognizer.IsAnagram(pattern,candidate)
                                select candidate).ToList();
            if (anagramsList.Count > 0)
            {
                anagramsList.Add(pattern);
                anagramsDictionary.Add(anagramsDictionary.Count, anagramsList);

            }
            return anagramsList;
        }
    }
}
