using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Sieradz.UCantTouchThis.ExtensionMethods;

namespace Toci.Hornets.Sieradz.UCantTouchThis.TasksTrainingTwo
{
    public class UCantTouchThisStringManipulations : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            var initialSubjectLength = subject.Length;
            subject = seek.Aggregate(subject, (current, letter) => current.TryRemove(letter.ToString()));
            return (initialSubjectLength - subject.Length) == seek.Length;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            return subject.OrderBy(x => x).SequenceEqual(seek.OrderBy(x => x));
        }

        protected override string GetNick()
        {
            return "UCantTouchThis";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject, seek);
        }
    }
}