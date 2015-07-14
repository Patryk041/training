using System;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Chojnecki.TrainingTwo
{
    internal class StringCheck : GhostRiderStringManipulationsBase
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

            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private string Alphabetize(string word)
        {
            var newWord = word.ToCharArray();
            Array.Sort(newWord);
            return new string(newWord);
        }

    }
}