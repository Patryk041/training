using System;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Bytom.AdamP.TaskTrainingTwo
{
    public class StringManipulator : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            if (String.IsNullOrEmpty(subject) || String.IsNullOrEmpty(seek))
                throw new System.ArgumentNullException();
            else
            {
                return subject.Contains(seek);
            }
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {   
            if (String.IsNullOrEmpty(subject) || String.IsNullOrEmpty(seek))
                throw new System.ArgumentNullException();

            if (seek.Length == 1)
            { 
                return subject.Contains(seek);
            }
            else
            {
                if (subject.Contains(seek.Substring(0, 1)))
                {
                    subject = String.Concat(subject.Substring(0, subject.IndexOf(seek.Substring(0, 1))), subject.Substring(subject.IndexOf(seek.Substring(0, 1) + 1)));
                    seek = seek.Substring(1);
                    return (IsStringElementsInString(subject, seek) && true);
                }
                else
                {
                    return false;
                }
                
            }
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            return ((subject.Length == seek.Length) && IsStringElementsInString(subject, seek));
        }

        protected override string GetNick()
        {
            return "AdamP";
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