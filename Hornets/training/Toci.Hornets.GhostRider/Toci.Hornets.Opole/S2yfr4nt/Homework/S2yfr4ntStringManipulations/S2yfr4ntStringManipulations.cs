using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntStringManipulations
{
    public class S2yfr4ntStringManipulations: GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.Equals(seek) || subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            foreach (var character in seek)
            {
                if (subject.Contains(character))
                {
                    subject.Remove(character);
                    
                    continue;
                }
                return false;
            }
            return true;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            return subject.OrderBy(c => c).SequenceEqual(seek.OrderBy(c => c));
        }

        protected override string GetNick()
        {
            return "S2yfr4nt";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject, seek);
        }
        protected override StringManipulationsResults Run(string subject, string seek)
        {
            var result = new StringManipulationsResults();

            result.Nick = GetNick();
            result.Subject = subject;
            result.Seek = seek;

            result.Type = GetType();

            result.IsAnagram = IsStringAnagramOfString(subject, seek);
            result.IsStringElementsInString = IsStringElementsInString(subject, seek);
            result.IsStringInString = IsStringInString(subject, seek);

            return result;
        }
    }
}