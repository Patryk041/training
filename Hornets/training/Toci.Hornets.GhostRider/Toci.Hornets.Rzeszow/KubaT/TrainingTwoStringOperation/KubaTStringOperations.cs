using System;
using System.Globalization;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.KubaT.TrainingTwoStringOperation
{
    public class KubaTStringOperations : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            char[] SubjectArray;
            char[] SeekArray;
            SubjectArray = subject.ToCharArray();
            SeekArray = seek.ToCharArray();
            int SeekCharQuantity = SeekArray.Length;
            for (int i = 0; i < SeekArray.Length; i += 1)
            {
                for (int j = 0; j < SubjectArray.Length; j += 1)
                {
                    if (SeekArray[i] == SubjectArray[j])
                    {
                        SeekCharQuantity -= 1;
                        break;
                    }
                    
                }
                
            }
            if (SeekCharQuantity == 0)
            {
                return true;
            }
            return false;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            char[] SubjectArray;
            char[] SeekArray;
            SubjectArray = subject.ToCharArray();
            SeekArray = seek.ToCharArray();
            Array.Sort(SubjectArray);
            Array.Sort(SeekArray);
            return SubjectArray.SequenceEqual(SeekArray);
        }

        protected override string GetNick()
        {
            return "KubaT";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject, seek);
        }
    }
}