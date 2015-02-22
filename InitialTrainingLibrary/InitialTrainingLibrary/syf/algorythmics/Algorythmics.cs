namespace InitialTrainingLibrary.syf.algorythmics
{
    public class Algorythmics
    {
        public static bool IsPalindrom(string word)
        {
            //radar, cyc. aga 
            for (int i = 0, j = word.Length - 1; i < word.Length; i++, j--)
            {
                if (word[i] != word[j])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsPalindrom2(string word)
        {
            for (int i = 0, j = word.Length - 1; i < word.Length/2; i++, j--)
            {
                if (word[i] != word[j])
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsAnagramUtil(string word1, string word2)
        {
            for (int i = 0; i < word1.Length; i++)
            {
                for (int j = 0; j < word2.Length; j++)
                {
                    if (word1[i] == word2[j])
                    {
                        break;
                    }
                    if (j == word2.Length - 1)
                    {
                        return false;
                    }
                    

                }
            }

            return true;
        }

        public static bool IsAnagram(string word1, string word2)
        {
            return IsAnagramUtil(word1, word2) && IsAnagramUtil(word2, word1);
        }

        public static string Rewers(string word)
        {
            string result = "";
            for (int i = word.Length-1; i >= 0; i--)
            {
              result =  result + word[i];

            }

            return result;
        }

        public static bool IsPalindrom11(string word)
        {
            return word == Rewers(word);
        }

    }
}
