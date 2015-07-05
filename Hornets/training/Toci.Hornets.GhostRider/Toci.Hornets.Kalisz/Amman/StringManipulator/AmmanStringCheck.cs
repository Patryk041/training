using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Kalisz.Amman.StringManipulator
{
    public class AmmanStringCheck : GhostRiderStringManipulationsBase
    {
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
            throw new System.NotImplementedException();
        }

        protected override string GetNick()
        {
            throw new System.NotImplementedException();
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            throw new System.NotImplementedException();
        }

        protected override StringManipulationsResults Run(string subject, string seek)
        {
            var result = new StringManipulationsResults();

            result.Nick = GetNick();
            result.Subject = subject;
            result.Seek = seek;

            result.Type = this.GetType();
            
            // TODO OPTIMIZATION
            result.IsAnagram = IsStringAnagramOfString(subject, seek);
            result.IsStringElementsInString = IsStringElementsInString(subject, seek);
            result.IsStringInString = IsStringInString(subject, seek);

            return result;
        }
    }
}