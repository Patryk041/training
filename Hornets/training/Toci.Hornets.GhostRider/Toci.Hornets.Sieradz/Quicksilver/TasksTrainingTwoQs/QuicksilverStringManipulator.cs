using System.Linq;
using System.Runtime.Remoting.Messaging;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Sieradz.Quicksilver.TasksTrainingTwoQs
{
    public class QuicksilverStringManipulator : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {

            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(seek))
                return false;
            if (subject.Length != seek.Length)
                return false;

            subject.ToLower();
            seek.ToLower();

            /*char[] subjectArray = subject.ToCharArray();
            char[] seekArray = seek.ToCharArray();*/

            if (subject.Contains(seek))
            {
                return true;
            }
            else
                return false;
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(seek))
                return false;
            if (subject.Length != seek.Length)
                return false;

            subject.ToLower();
            seek.ToLower();

            foreach (var c in seek)
            {
                if (subject.Contains(c))
                    continue;
                return false;
            }
            return true;


        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
           
            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(seek))
                return false;
            if (subject.Length != seek.Length)
                return false;

            subject.ToLower();
            seek.ToLower();

            foreach (char c in seek)
            {
                int o = subject.IndexOf(c);
                if (o >= 0)
                    subject = subject.Remove(o, 1);
                else
                    return false;
            }
            return string.IsNullOrEmpty(subject);

            /*if (subject.Length == seek.Length)
            {
                var count = new int[1024];
                foreach (var c in subject)
                {
                    ++count[c];
                }
                return seek.All(t => --count[c] >= 0);
            }
            return false;*/

        }

        protected override string GetNick()
        {
            return "Quicksilver";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            var result = new StringManipulationsResults();

            result.Nick = GetNick();
            result.Subject = subject;
            result.Seek = seek;

            result.Type = this.GetType();

            result.IsAnagram = IsStringAnagramOfString(subject, seek);
            result.IsStringElementsInString = IsStringElementsInString(subject, seek);
            result.IsStringInString = IsStringInString(subject, seek);

            return result;
        }
    }
}