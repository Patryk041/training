using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Sieradz.TypowyAdam.TrainingTwoTasks.StringManipulator
{
    public class TypowyAdamStringManipulator : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            if(subject.Length > seek.Length)
                return Regex.IsMatch(subject, seek); 
            return false;
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            foreach (var character in seek)
            {
                if (subject.Contains(character))
                    continue;
                return false;
            }
            return true;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            if (subject.Length != seek.Length) return false;
            char[] subjectArray = subject.ToCharArray().AsParallel().WithDegreeOfParallelism(4).OrderBy(c => c).ToArray();
            char[] seekArray = seek.ToCharArray().AsParallel().WithDegreeOfParallelism(4).OrderBy(c => c).ToArray();
            return subjectArray.SequenceEqual(seekArray);
        }

        protected override string GetNick()
        {
            return "TypowyAdam";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            subject.ToLower();
            seek.ToLower();
            
            return Run(subject, seek);
        }

        protected override StringManipulationsResults Run(string subject, string seek)
        {
            var result = new StringManipulationsResults();

            result.Nick = GetNick();
            result.Subject = subject;
            result.Seek = seek;

            result.Type = this.GetType();


            result.IsStringElementsInString = IsStringElementsInString(subject, seek);
            if (!result.IsStringElementsInString)
            {
                result.IsStringInString = false;
                result.IsAnagram = false;
                return result;
            }

            result.IsStringInString = IsStringInString(subject, seek);
            result.IsAnagram = IsStringAnagramOfString(subject, seek);

            return result;
        }
    }
}