using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Wroclaw.Wyga
{
    public class StringTask : GhostRiderStringManipulationsBase
    {
       

        protected override bool IsStringInString(string subject, string seek)
        {
            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(seek)) return false;
            if (subject.Contains(seek))
                return true;
            return false;
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(seek)) return false;
            foreach (var character in seek)
            {
                var indexOfCharacter = subject.IndexOf(character);
                if (indexOfCharacter == -1) return false;
                subject = subject.Remove(indexOfCharacter, 1);
            }

            return true;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(seek)) return false;

            for (var i = 0; i < subject.Count(); i++)
            {
                var first = seek[i];
                var second = subject[subject.Count() - 1 - i];
                if (first != second) return false;
            }
            return true;
        }

        protected override string GetNick()
        {
            return "Wyga";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            var result = new StringManipulationsResults();

            result.Nick = GetNick();
            result.Subject = subject;
            result.Seek = seek;

            result.Type = this.GetType();

            result.IsAnagram = IsStringAnagramOfString(subject, seek);
            result.IsStringElementsInString = IsStringElementsInString(subject, seek);
            result.IsStringInString = IsStringInString(subject, seek);

            return result;
        }
    }
}