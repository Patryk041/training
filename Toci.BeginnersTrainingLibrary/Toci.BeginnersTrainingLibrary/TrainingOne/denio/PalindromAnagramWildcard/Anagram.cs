using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.denio.PalindromAnagramWildcard
{
    public class Anagram
    {
        //private string txt1 = "Mother In Law";
        //private string txt2 = "The moral win";//"Woman Hitler";
        private string[] wynik;
        private string tet;
        private string tet2;

        public string[] tAnagram(string txt1, string txt2)
        {
            if (String.Concat((txt1.ToLower().Replace(" ", "")).OrderBy(c => c)) ==
                String.Concat((txt2.ToLower().Replace(" ", "")).OrderBy(c => c)))
            {
                wynik = new[] {txt1, txt2};

            }

            return wynik;
            
        }
    }
}
