using System.Globalization;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Opole.Dziusio.StringCompare
{
    public class DziusioStringManipulationsResults : GhostRiderStringManipulationsBase
    {
        public StringManipulationsResults Dziusio = new StringManipulationsResults();
        

        protected override bool IsStringInString(string subject, string seek)
        {
            throw new System.NotImplementedException();
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            throw new System.NotImplementedException();
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            if (subject.Length != seek.Length)
            {
                return false;
            }

    
            if (Equals(subject, seek))
            {
                return true;
            }
            return false;
        }

        protected override string GetNick()
        {
            return "Dziusio";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            throw new System.NotImplementedException();
        }
    }
}