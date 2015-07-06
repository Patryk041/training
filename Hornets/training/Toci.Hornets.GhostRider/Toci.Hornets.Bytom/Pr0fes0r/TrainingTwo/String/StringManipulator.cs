using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Bytom.Pr0fes0r.TrainingTwo.String
{
    class StringManipulator:GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            throw new NotImplementedException();
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            throw new NotImplementedException();
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            string word;
            SortrString anagram = new SortrString();
            anagram.Sort(subject,seek);

            
        }

        protected override string GetNick()
        {
            return "Pr0fes0r";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            throw new NotImplementedException();
        }
    }
}
