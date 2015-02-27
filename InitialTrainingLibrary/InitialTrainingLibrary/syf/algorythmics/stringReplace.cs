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
            string wynik = "";
            if (CzyTeksWystepuje(slowo1, slowo2) == true)
            {
                int j = 0;
                
                for (int i = 0; i < slowo1.Length; i++)
                {
                    if (i < slowo1.Length)
                    if (slowo1[i] == slowo2[j])
                     {
                        i += slowo2.Length;    
                    }
                    if (i < slowo1.Length)
                    {
                        wynik += slowo1[i];
                    }
                    if (i == slowo1.Length)
                    {
                        return wynik;
                    }
                }
            }
            return wynik;
        }

        public static string DoklejTekst(string slowo1, string slowo2, string slowo3)
        {
            string tekst = "";
            tekst = WytnijTekst(slowo1, slowo2);

            for (int i = 0; i < slowo3.Length; i++)
            {
                tekst += slowo3[i];
            }
            return tekst;
        }
    }
}
