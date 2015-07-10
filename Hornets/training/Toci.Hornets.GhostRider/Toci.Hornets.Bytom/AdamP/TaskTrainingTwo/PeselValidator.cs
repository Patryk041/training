namespace Toci.Hornets.Bytom.AdamP.TaskTrainingTwo
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
            throw new System.NotImplementedException();
        }

        public override bool IsPeselValid(string pesel)
        {
            throw new System.NotImplementedException();
        }
    }
}