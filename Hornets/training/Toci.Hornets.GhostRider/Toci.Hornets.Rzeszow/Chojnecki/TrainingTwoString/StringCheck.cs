using System;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Chojnecki.TrainingTwoString
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
            var subjectlist = subject.ToCharArray();
            var seeklist = seek.ToCharArray();
            for (var x = 0; x < seeklist.Length; x++)
            {
                var subjectCount = subjectlist.Count(t => t == seeklist[x]);
                var seekCount = seeklist.Count(t => t == seeklist[x]);
                if (subjectCount < seekCount || seekCount==0) return false;
            }
            return true;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            return (Alphabetize(subject) == Alphabetize(seek));
        }
        
        private string Alphabetize(string word)
        {
            var newWord = word.ToCharArray();
            Array.Sort(newWord);
            return new string(newWord);
        }
       
        protected override string GetNick()
        {
            return "Andrzej";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            var result = new StringManipulationsResults();


            result.IsAnagram = IsStringAnagramOfString(subject, seek);

            if (result.IsAnagram) result.IsStringElementsInString = true;
            else result.IsStringElementsInString = IsStringElementsInString(subject, seek);
           
            if (result.IsStringElementsInString == false) result.IsStringInString = false;
            else result.IsStringInString = IsStringInString(subject, seek);         

            return result;
        }

       
    }
}