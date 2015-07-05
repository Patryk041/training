using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks
{
    public class TypowyAdamPeselValidator : PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            throw new System.NotImplementedException();
        }

        protected override bool Checksum(string pesel)
        {
            throw new System.NotImplementedException();
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            throw new System.NotImplementedException();
        }

        public override string GetNick()
        {
            return "TypowyAdam";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11)
                return false;
            if(Checksum(pesel))
                return true;
            if (ValidateDate(1, 2, 3))
                return true;
            return false;
        }
    }
}