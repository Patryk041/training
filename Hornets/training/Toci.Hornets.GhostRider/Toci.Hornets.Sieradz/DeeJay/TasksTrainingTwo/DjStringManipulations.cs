using System;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Sieradz.DeeJay.TasksTrainingTwo
{
    public class DjStringManipulations : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            return seek.Distinct().All(c => subject.Count(x => x.Equals(c)) >= seek.Count(x => x.Equals(c)));
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            if (subject.Length != seek.Length)
                return false;

            var arrayOfCharsFromSubject = subject.ToArray();
            var arrayOfCharsFromSeek = seek.ToArray();

            Array.Sort(arrayOfCharsFromSubject);
            Array.Sort(arrayOfCharsFromSeek);

            var orderedSubject = new string(arrayOfCharsFromSubject);
            var orderedSeek = new string(arrayOfCharsFromSeek);

            return orderedSubject.Equals(orderedSeek);
        }

        protected override string GetNick()
        {
            return "DeeJay";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            var result = new StringManipulationsResults();

            result.Nick = GetNick();
            result.Subject = subject;
            result.Seek = seek;

            result.Type = this.GetType();

            CheckStrings(ref result);

            return result;
        }

        private void CheckStrings(ref StringManipulationsResults result)
        {
            var subject = result.Subject;
            var seek = result.Seek;

            if (String.IsNullOrEmpty(subject)
                || String.IsNullOrEmpty(seek)
                || seek.Length > subject.Length)
            {
                result.IsAnagram = false;
                result.IsStringInString = false;
                result.IsStringElementsInString = false;
                return;
            }

            if (subject.Equals(seek))
            {
                result.IsAnagram = true;
                result.IsStringInString = true;
                result.IsStringElementsInString = true;
                return;
            }

            result.IsAnagram = IsStringAnagramOfString(subject, seek);
            if (result.IsAnagram)
            {
                result.IsStringElementsInString = true;
            }

            result.IsStringInString = IsStringInString(subject, seek);
            if (result.IsStringInString)
            {
                result.IsStringElementsInString = true;
                return;
            }

            if (!result.IsStringElementsInString)
            {
                result.IsStringElementsInString = IsStringElementsInString(subject, seek);
            }
        }
    }
}