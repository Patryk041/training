using System;
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
            var subjectArray = subject.ToCharArray();
            var seekArray = seek.ToCharArray();
            int seekCharQuantity = seekArray.Length;
            for (int i = 0; i < seekArray.Length; i += 1)
            {
                for (int j = 0; j < subjectArray.Length; j += 1)
                {
                    if (seekArray[i] == subjectArray[j])
                    {
                        seekCharQuantity -= 1;
                        break;
                    }
                    
                }
                
            }
            if (seekCharQuantity == 0)
            {
                return true;
            }
            return false;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            var subjectArray = subject.ToCharArray();
            var seekArray = seek.ToCharArray();
            Array.Sort(subjectArray);
            Array.Sort(seekArray);
            return subjectArray.SequenceEqual(seekArray);
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