using Toci.Hornets.GhostRider.TrainingTwo.Homework;

namespace Toci.Hornets.Opole.Startup.TrainingOne.S2yfr4nt
{
    public class S2yfr4ntPeselValidator: PeselValidator
    {
        protected override bool ValidateDate(int year, int month, int day)
        {
            throw new System.NotImplementedException();
        }

        public override bool IsPeselValid(string pesel)
        {
            return true;
        }
    }
}