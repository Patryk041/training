using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.algorythmics
{
    public class StringReplace
    {
        public static bool CzyTeksWystepuje(string slowo1, string slowo2)
        {
            int j = 0;
            for (int i = 0; i < slowo1.Length; i++)
            {
                if (slowo1[i] == slowo2[j])
                {
                    j++;
                    if (slowo2.Length==j)
                    {
                        return true;
                    }
                }
                else
                {
                    j = 0;
                }
                     
            }
            return false;
        }

        public static string WytnijTekst(string slowo1, string slowo2)
        {
            if (CzyTeksWystepuje(slowo1, slowo2) == true)
            {
                int j = 0;
                string wynik = "";
                for (int i = 0; i <= slowo1.Length; i++)
                {  
                    if (slowo1[i] == slowo2[j])
                    {
                        i += slowo2.Length-1;    
                    }
                    wynik += slowo1[i];
                    if (i == slowo1.Length-1)
                    {
                        return wynik;
                    }
                }
            }
            return null;
        }
    }
}
