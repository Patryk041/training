using System;
using System.Collections.Generic;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.TextOperations
{
    public abstract class Expression
    {
        protected string[] wordsToCheck;

        public Expression(string[] words)
        {
            wordsToCheck = words;
        }

        public string[] selectCorrectWords()
        {
            var listOfCorrectWords = new List<string>();

            foreach (string word in wordsToCheck)
            {
                if (isWordCorrectCheck(word))
                {
                    listOfCorrectWords.Add(word);
                    Console.WriteLine(word);
                }
            }
            return listOfCorrectWords.ToArray();
        }

        protected abstract bool isWordCorrectCheck(string word);
    }
}
