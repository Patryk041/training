using System;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Opole.Lausion.TasksTraningTwo.StringManipulation
{
    public class LausionStringManipulation:GhostRiderStringManipulationsBase
    {
        // true: beata; at, ata, ta, ea
        // false: beata; ae, eb, aa
        protected override bool IsStringInString(string subject, string seek)
        {
            if (subject.Contains(seek)&&seek.Length<subject.Length)
                return true;
            else
            {
                return false;
            }
        }
        // true: beata; aat, taae, aea
        // false: beata; aaa, taaa, tta, aee
        protected override bool IsStringElementsInString(string subject, string seek)
        {
           //????????????????????
            return false;
        }
        // true: beata; ataeb, aateb, tbaea
        // false: beata; aaateb, fdwgdw
        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            if (subject.Length != seek.Length)
                return false;
            else
            {
                char[] subjectChars = subject.ToCharArray();
                char[] seekChars = seek.ToCharArray();
                Array.Sort(subjectChars);
                Array.Sort(seekChars);
                subject = subjectChars.ToString();
                seek = subjectChars.ToString();
                if (subject.Equals(seek))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        protected override string GetNick()
        {
            return "Lausion";
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