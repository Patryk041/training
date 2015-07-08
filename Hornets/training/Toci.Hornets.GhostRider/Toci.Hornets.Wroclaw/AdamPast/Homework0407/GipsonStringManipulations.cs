using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Wroclaw.AdamPast.Homework0407
{
    public class GipsonStringManipulations : GhostRiderStringManipulationsBase
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
            if (seek.Length != subject.Length)
                return false;


            throw new NotImplementedException();
        }

        protected override string GetNick()
        {
            return "gipson";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            throw new NotImplementedException();
        }
    }
}
