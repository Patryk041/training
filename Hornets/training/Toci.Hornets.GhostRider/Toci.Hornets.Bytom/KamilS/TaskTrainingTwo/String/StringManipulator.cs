using System;
using System.IO;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Bytom.KamilS.TaskTrainingtTwo
{
    public class StringManipulator : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            if (!subject.Contains(seek))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            char[] subjectChar = subject.ToCharArray();
            char[] seekChar = seek.ToCharArray();
            int SeekLength = seekChar.Length;
            for (int i = 0; i < subjectChar.Length; i++)
            {
                for (int j = 0; j < seekChar.Length; j++)
                {
                    if (subjectChar[i] == seekChar[j])
                    {
                        SeekLength = SeekLength - 1;
                        break;
                    }
                }
                if (SeekLength == 0)
                {
                    return true;
                }
            }
            return false;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            if (subject.Length == seek.Length)
            {
                char[] subjectChar = subject.ToLower().ToCharArray();
                char[] seekChar = seek.ToLower().ToCharArray();
                Array.Sort(seekChar);
                Array.Sort(subjectChar);

                String newSubject = new String(subjectChar);
                String newSeek = new String(seekChar);

                if (newSeek == newSubject)
                {
                    return true;
                }
            }
            return false;
        }

        protected override string GetNick()
        {
            return ("KamilS");
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            throw new System.NotImplementedException();
        }
    }
}