using System.Collections.Generic;
using System.Linq;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.TextValidator
{
    public abstract class ZieluTextValidation
    {
        List<string> _listOfCorrectWords = new List<string>();

        public string[] Validate(string text, string pattern)
        {
            var tableOfText = ConvertToTable(text);
            foreach (var item in tableOfText.Where(item => DoesMatch(item, pattern)).Where(item => _listOfCorrectWords != null))
            {
                _listOfCorrectWords.Add(item);
            }
            return _listOfCorrectWords.ToArray();
        }

        protected static string[] ConvertToTable(string text)
        {
            return text.Split(' ');
        }

        protected abstract bool DoesMatch(string text, string pattern);
    }
}
