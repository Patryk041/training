using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Legnica.Patryk_Stulczewski.Utils;

namespace Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.StringManipulations
{
    public class PatrykStringManipulationsBase : GhostRiderStringManipulationsBase
    {
        public PatrykStringManipulationsBase()
        {
        }

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
            foreach (var sign in seek)
            {
                if (subject.Contains(sign))
                    subject = RemoveSign(subject, sign);
                else
                    return false;
            }
            return true;
        }

        // true: beata; ataeb, aateb, tbaea
        // false: beata; aaateb, fdwgdw
        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            return subject.Length == seek.Length && subject.Sort() == seek.Sort();
        }

        protected override string GetNick()
        {
            return "Patryk Stulczewski";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject, seek);
        }

        private string RemoveSign(string str, char sign)
        {
            return str.Remove(str.IndexOf(sign), 1);
        }
    }
}
