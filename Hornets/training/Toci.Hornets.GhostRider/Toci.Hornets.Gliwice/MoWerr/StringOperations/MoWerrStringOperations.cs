using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Gliwice.MoWerr.StringOperations
{
    public class MoWerrStringOperations : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            var subjectList = subject.ToList();
            var seekList = seek.ToList();

            var resultList = new List<char>();

            foreach (var c in seekList)
            {
                if (!subjectList.Contains(c)) continue;
                
                    resultList.Add(c);
                    subjectList.Remove(c);
                
            }

            return seekList.SequenceEqual(resultList);
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            var subjectList = subject.ToList();
            var seekList = seek.ToList();

            subjectList.Sort();
            seekList.Sort();

            return subjectList.SequenceEqual(seekList);
        }

        protected override string GetNick()
        {
            return "MoWerr";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject, seek);
        }

        protected override StringManipulationsResults Run(string subject, string seek)
        {
            var result = new StringManipulationsResults
            {
                Nick = GetNick(),
                Subject = subject,
                Seek = seek,
                Type = GetType()
            };

            if (IsStringAnagramOfString(subject, seek))
            {
                result.IsAnagram = true;
                result.IsStringElementsInString = true;
                result.IsStringInString = IsStringInString(subject, seek);
            }
            else if (IsStringInString(subject, seek))
            {
                result.IsStringInString = true;
                result.IsStringElementsInString = true;
                result.IsAnagram = false;
            }
            else
            {
                result.IsAnagram = false;
                result.IsStringElementsInString = false;
                result.IsStringElementsInString = IsStringElementsInString(subject, seek);
            }

            return result;
        }
    }
}