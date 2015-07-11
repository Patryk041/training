using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Foonesh.TrainingTwo.StringManipulations
{
    public class StringManipulationsFoonesh : GhostRiderStringManipulationsBase
    {

        private Dictionary<char, int> StringToDict(string word)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in word)
            {
                if (dict.ContainsKey(c)) dict[c]++;
                else dict.Add(c, 1);
            }

            return dict;
        }

        protected override bool IsStringInString(string subject, string seek)
        {
            if (subject.Length < seek.Length) return false;
            if (subject == seek) return true;

            Dictionary<char, int> letters = StringToDict(subject);

            foreach (char c in seek)
            {
                if (!letters.ContainsKey(c)) return false;
                letters[c]--;
                if (letters[c] == 0) letters.Remove(c);
            }

            return letters.Count >= 0;
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            if (subject == seek) return true;

            Dictionary<char, int> letters = StringToDict(subject);

            /* foreach (char c in seek)
               {
                   if (!letters.ContainsKey(c)) return false;
               } 
               return true; */

            return seek.All(c => letters.ContainsKey(c));
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            if (subject.Length != seek.Length) return false;
            if (subject == seek) return true;

            Dictionary<char, int> letters = StringToDict(subject);

            foreach (char c in seek)
            {
                if (!letters.ContainsKey(c)) return false;
                letters[c]--;
                if (letters[c] == 0) letters.Remove(c);
            }

            return letters.Count == 0;
        }

        protected override string GetNick()
        {
            return "foonesh";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            var result = new StringManipulationsResults
            {
                Nick = GetNick(),
                Subject = subject,
                Seek = seek,
                Type = GetType(),
                IsAnagram = IsStringAnagramOfString(subject, seek)
            };

            if (result.IsAnagram)
            {
                result.IsStringElementsInString = true;
                result.IsStringInString = true;
                return result;
            }

            result.IsStringElementsInString = IsStringElementsInString(subject, seek);

            if (result.IsStringElementsInString)
            {
                result.IsStringInString = true;
                return result;
            }

            result.IsStringInString = IsStringInString(subject, seek);

            return result;
        }
    }
}