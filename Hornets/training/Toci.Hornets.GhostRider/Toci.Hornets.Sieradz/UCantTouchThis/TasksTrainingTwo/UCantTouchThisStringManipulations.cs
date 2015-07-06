using System;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

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
            throw new System.NotImplementedException();
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            return SortString(subject) == SortString(seek);
        }

        private char[] SortString(string stringToSort)
        {
            var array = stringToSort.ToCharArray();
            Array.Sort(array);
            return array;
        }

        protected override string GetNick()
        {
            return "UCantTouchThis";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            throw new System.NotImplementedException();
        }
    }
}