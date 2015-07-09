using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Legnica.Michał_Zembik
{
    public class ZadanieStringManipulations : GhostRiderStringManipulationsBase
    {
        // true: beata; at, ata, ta, ea
        // false: beata; ae, eb, aa
        protected override bool IsStringInString(string subject, string seek)
        {
            throw new System.NotImplementedException();
        }

        // true: beata; aat, taae, aea
        // false: beata; aaa, taaa, tta, aee
        protected override bool IsStringElementsInString(string subject, string seek)
        {
            throw new System.NotImplementedException();
        }

        // true: beata; ataeb, aateb, tbaea
        // false: beata; aaateb, fdwgdw
        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            throw new System.NotImplementedException();
        }

        protected override string GetNick()
        {
            throw new System.NotImplementedException();
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
              return Run(subject, seek);
        }
    }
}