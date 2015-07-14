using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Bytom.AdamP.TaskTrainingTwo
{
    public class AdamPStringManipulator : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return false;
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            return false;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            return false;
        }

        protected override string GetNick()
        {
            return "AdamP";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return null;
        }
    }
}