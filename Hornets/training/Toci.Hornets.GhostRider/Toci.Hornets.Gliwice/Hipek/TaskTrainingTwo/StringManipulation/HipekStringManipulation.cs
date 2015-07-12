using System.Linq;
using System.Runtime.Remoting.Messaging;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Gliwice.Hipek.TaskTrainingTwo.StringManipulation
{
    public class HipekStringManipulation : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject != null && seek != null && subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            if (subject == null || seek == null) 
                return false;
            foreach (var item in seek)
            {
                subject = subject.Contains(item) ? subject.Remove(subject.IndexOf(item), 1) : null;
                if (subject == null)
                    return false;
            }
            return true;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            return subject != null && seek != null && subject.ToCharArray().OrderBy(x => x).SequenceEqual(seek.ToCharArray().OrderBy(x => x));
        }

        protected override string GetNick()
        {
            return "Hipek";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject, seek);
        }
    }
}