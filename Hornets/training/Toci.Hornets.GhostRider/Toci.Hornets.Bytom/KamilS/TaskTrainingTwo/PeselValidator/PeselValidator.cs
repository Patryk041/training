namespace Toci.Hornets.Bytom.KamilS.TaskTrainingTwo.PeselValidator
{
    public class PeselValidator : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
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
            return "KamilS";
        }

        public override bool IsPeselValid(string pesel)
        {
            throw new System.NotImplementedException();
        }
    }
}