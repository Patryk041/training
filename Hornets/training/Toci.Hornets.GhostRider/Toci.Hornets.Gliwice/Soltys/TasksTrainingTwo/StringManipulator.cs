using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Gliwice.Soltys.TasksTrainingTwo
{
    public class StringManipulator : GhostRiderStringManipulationsBase
    {
        private const string MyNick = "Sołtys";
        
        protected override bool IsStringInString(string subject, string seek)
        {
            // Short solution
//            return subject.Contains(seek);

            // Long solution
            var firstCharacter = seek[0];
            var iterationLength = subject.Length - seek.Length;

            if (iterationLength <= 0)
                return false;

            for (int i = 0; i < iterationLength; i++)
            {
                if (subject[i] == firstCharacter)
                {
                    var subjectSubstring = subject.Substring(i, seek.Length);
                    if (subjectSubstring == seek)
                        return true;
                }
            }
            return false;
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            var subjectCharacterList = subject.ToList();

            foreach (var character in seek.ToArray())
            {
                if (subjectCharacterList.Remove(character) == false)
                {
                    return false;
                }
            }

            return true;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            var subjectCharArray = subject.ToArray();
            Array.Sort(subjectCharArray);

            var seekCharArray = subject.ToArray();
            Array.Sort(seekCharArray);

            if (subjectCharArray.Length != seekCharArray.Length)
                return false;

            for (int i = 0; i < subjectCharArray.Length; i++)
            {
                if (subjectCharArray[i] != seekCharArray[i])
                    return false;
            }

            return true;
        }

        protected override string GetNick()
        {
            return MyNick;
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject, seek);
        }
    }
}
