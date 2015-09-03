using System;
using System.Linq;
using System.Text.RegularExpressions;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Wroclaw.Ayuu.TrainingTwo
{
    public class AyuuStringManipulations : GhostRiderStringManipulationsBase
    {
        // true: beata; at, ata, ta, ea
        // false: beata; ae, eb, aa
        protected override bool IsStringInString(string subject, string seek)
        {
            if (subject.Contains(seek))
                return true;
            return false;
        }

        // true: beata; aat, taae, aea
        // false: beata; aaa, taaa, tta, aee
        protected override bool IsStringElementsInString(string subject, string seek)
        {
            // I have no idea how to do this, I will think about it 
            return false;
        }

        // true: beata; ataeb, aateb, tbaea
        // false: beata; aaateb, fdwgdw
        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            if(subject.Length == seek.Length && subject.All(seek.Contains))
                return true;
            return false;
        }

        protected override string GetNick()
        {
            return "Ayuu";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject, seek);
        }
    }
}