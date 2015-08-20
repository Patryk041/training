using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Wroclaw.Wudzinski.Homework2
{
    public class WudzinskiStringManipulations : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject!=null && seek!=null && subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            if (subject == null || subject.Equals("") || seek == null)
                return false;

            char[] subjectArray = subject.ToCharArray();
            char[] seekArray = seek.ToCharArray();

            List<char> seekList = seekArray.Cast<char>().ToList();
            List<char> subjectkList = subjectArray.Cast<char>().ToList();
            var i = 0;
            foreach (var letter in seekList)
            {
                i = 1;
                foreach (var character in subjectkList)
                {
                    if (character.Equals(letter))
                    {
                        subjectkList.Remove(letter);
                        break;
                    }
                    if (i == subjectkList.Count)
                        return false;
                    i++;
                }
            }
            return subject!=null && seek!=null;

        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            if (subject == null || seek == null)
                return false;
            
            subject = SortString(subject);
            seek = SortString(seek);

            return subject.Length == seek.Length && subject.Equals(seek);
        }

        protected override string GetNick()
        {
            return "Wudzinski";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject, seek);
        }

        private string SortString(string stringToSort)
        {
            char[] finalString = stringToSort.ToCharArray();
            Array.Sort(finalString);
            return new string(finalString);
        }
    }
}