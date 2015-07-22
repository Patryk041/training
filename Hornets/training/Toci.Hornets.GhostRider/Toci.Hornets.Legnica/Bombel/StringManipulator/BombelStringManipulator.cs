using System;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Legnica.Bombel.StringManipulator
{
    public class BombelStringManipulator : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.Equals(seek) || subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            var subjectList = subject.ToList();
            foreach (var element in seek)
            {
                if (!subjectList.Contains(element)) return false;
                subjectList.Remove(element);
            }
            return true;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            if (subject.Length != seek.Length) return false;
            return StringSort(subject).Equals(StringSort(seek));
        }

        protected override string GetNick()
        {
            return "Bombel";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject.ToLower(), seek.ToLower()); 
        }

        protected string StringSort(string str)
        {
            var tab = str.ToCharArray();
            Array.Sort(tab);
            return new string(tab);
        }
    }
}