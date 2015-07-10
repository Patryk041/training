using System;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Bytom.Coffee13.TaskTrainingTwo.StringManipulator
{
    public class CoffeeStringManipulations : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            subject = subject.ToLower();
            seek = seek.ToLower();

            

            char[] subjectLetters = subject.ToCharArray();
            char[] seekLetters = seek.ToCharArray();

            var LetterCount = seekLetters.Length;

            for (var i = 0; i < subjectLetters.Length; i++)
            {
                for (var j = 0; j < seekLetters.Length; j++)
                {
                    if (subjectLetters[i] == seekLetters[i])
                    {
                        LetterCount --;
                        break;
                    }
                    if (LetterCount == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            if (subject.Length == seek.Length)
            {
                subject = subject.ToLower();
                seek = seek.ToLower();

                char[] subjectLetters = subject.ToCharArray();
                char[] seekLetters = seek.ToCharArray();

                Array.Sort(subjectLetters);
                Array.Sort(seekLetters);

                if (seekLetters == subjectLetters)
                {
                    return true;
                }
               
            }
            return false;
        }

        protected override string GetNick()
        {
            return "Coffee13";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject,seek);
        }
    }
}