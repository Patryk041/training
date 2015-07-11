using System.Collections.Generic;
using System.Diagnostics;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Gliwice.Rudi
{
    public class RudiStringManipulations : GhostRiderStringManipulationsBase
    {

        protected override bool IsStringInString(string subject, string seek)
        {
            char[] listSub = subject.ToCharArray();
            char[] listSeek = seek.ToCharArray();

            for (int i = 0; i < listSub.Length - listSeek.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < listSeek.Length; j++)
                {
                    if (listSeek[j + i] == listSub[i + j])
                        counter++;
                    if (counter == listSub.Length)
                        return true;
                }

            }
            return false;
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            List<char> listSub = new List<char>(subject.Length);
            List<char> listSeek = new List<char>(seek.Length);

            for (int i = 0; i <listSeek.Count; i++)
            {
                if (listSeek.Contains(listSub[i]))
                {
                    listSeek.RemoveAt(i);
                    listSub.RemoveAt(i);
                }

            }

            if (listSub.Count == 0)
                return true;

            return false;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            if (subject.Length == seek.Length)
                return IsStringElementsInString(subject, seek);

            return false;
        }

        protected override string GetNick()
        {
            return "Rudi";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject, seek);
        }
    }
}