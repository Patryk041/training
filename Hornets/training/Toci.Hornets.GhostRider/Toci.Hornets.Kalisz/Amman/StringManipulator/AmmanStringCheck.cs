using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Kalisz.Amman.StringManipulator.Workers;

namespace Toci.Hornets.Kalisz.Amman.StringManipulator
{
    public class AmmanStringCheck : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return Stringception.IsStringcepted(subject, seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            return StringElement.IsElement(subject, seek);
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            return Anagram.IsAnagram(subject, seek);
        }

        protected override string GetNick()
        {
            return "Amman";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            var result = new StringManipulationsResults
            {
                Nick = GetNick(),
                Subject = subject,
                Seek = seek,
                Type = GetType(),
                IsAnagram = IsStringAnagramOfString(subject, seek),
                IsStringElementsInString = IsStringElementsInString(subject, seek),
                IsStringInString = IsStringInString(subject, seek)
            };

            return result;
        }
        
        }
    }
