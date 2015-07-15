using System;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Legnica.Filip_Sokolowski.homeWork.stringManipulator
{
    public class StringManipulator : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            return (SortString(subject).Contains(SortString(seek)));
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            if (subject.Length != seek.Length)
            {
                return false;
            }
            return (SortString(subject).Equals(SortString(seek)));
        }

        protected string SortString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }

        protected override string GetNick()
        {
            return "Filip Sokolowski";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject, seek);
        }
    }
}