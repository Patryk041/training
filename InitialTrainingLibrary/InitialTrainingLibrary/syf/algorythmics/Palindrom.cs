using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.algorythmics
{
    public class Palindrom
    {
        public bool PalindromValidator(string word)
        {
            for (int i = 0, j = word.Length; i > word.Length/2; i++, j--)
            {
                if (word[i] != word[j])
                {
                    return true;
                }
               
            }
            return false;
        }

        public static int tekst(string word1, string word2)
        {
            int j = 0;
            int k = 0;
            int counter = 0;
            for (int i = 0; i < word1.Length; i++)
            {
                    if (word1[i] == word2[j])
                    {
                        j++;
                        counter++;
                        k++;

                        if (counter == word2.Length)
                        {
                            return k;
                        }
                    }
                    else
                    {
                        counter = 0;
                        j = 0;
                    }     
            }
            return -1;
        }

        public static string podmiana(string word1, string word2, string word3)
        {
            int pozycja;
            string newWord = "";
            string newWord1 = "";
            string koncowe;
            pozycja = tekst(word1, word2);
            for (int j = 0; j < pozycja; j++)
            {
                newWord += word1[j].ToString();
            }

            newWord += word3;

            for (int i=pozycja + word2.Length; i < word1.Length; i++)
            {

                newWord += word1[i].ToString();
            }
            return newWord;
        }
    }
    

}
