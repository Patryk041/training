using System;
using System.Diagnostics;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Chojnecki.TrainingTwo
{
    public class StringCheck : GhostRiderStringManipulationsBase
    {
        // true: beata; at, ata, ta, ea
        // false: beata; ae, eb, aa
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.Contains(seek);
        }

        // true: beata; aat, taae, aea
        // false: beata; aaa, taaa, tta, aee
        protected override bool IsStringElementsInString(string subject, string seek)
        {
            if (seek == "") return false;
            char[] subjectlist = subject.ToCharArray();
            char[] seeklist = seek.ToCharArray();
            for(int x=0;x<seeklist.Length;x++)
            {
                int subjectCount = 0;
                int seekCount = 0;
                for (int i = 0; i < subjectlist.Length; i++)
                {
                    if (subjectlist[i] == seeklist[x]) subjectCount++;
                }
                for (int i = 0; i < seeklist.Length; i++)
                {
                    if (seeklist[i] == seeklist[x]) seekCount++;
                }
                if (subjectCount < seekCount) return false;
            }
            return true;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            return (Alphabetize(subject) == Alphabetize(seek));
        }

        protected override string GetNick()
        {
            return "Andrzej";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            var result = new StringManipulationsResults();

            result.Nick = GetNick();
            result.Subject = subject;
            result.Seek = seek;

            result.Type = this.GetType();
            result.IsAnagram = IsStringAnagramOfString(subject, seek);

            if (result.IsAnagram == true)
            {
                result.IsStringElementsInString = true;
            }
            else
            {
                result.IsStringElementsInString = IsStringElementsInString(subject, seek);
            }     
            if (result.IsStringElementsInString == false)
            {
                result.IsStringInString = false;
            }
            else
            {
                result.IsStringInString = IsStringInString(subject, seek);
            }
            

            return result;
        }

        private string Alphabetize(string word)
        {
            var newWord = word.ToCharArray();
            Array.Sort(newWord);
            return new string(newWord);
        }

    }
}