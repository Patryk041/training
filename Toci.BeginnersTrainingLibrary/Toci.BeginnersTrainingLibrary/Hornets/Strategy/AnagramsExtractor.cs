using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.Hornets.Strategy
{
    public class AnagramsExtractor
    {
        public string[] ExtractAnagrams(AnagramRecognizer anagramRecognizer, string[] anagramArray)
        {

            List<string> resultArrayList = new List<string>();

            for (int i = 0; i < anagramArray.Count(); i++)
            {
                for (int j = 0; j < anagramArray.Count(); j++)
                {
                    //TODO 
                    if (anagramRecognizer.IsAnagram(anagramArray[i], anagramArray[j]))
                    {
                        resultArrayList.Add(anagramArray[i]);
                    }
                    

                }

            }

            return resultArrayList.ToArray();

        }
    }
}
