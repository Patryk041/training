namespace Toci.Hornets.Bytom.KamilS.TaskTrainingTwo.PeselValidator
{
    public class PeselValidator : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            string year = pesel.Substring(0, 2);
            string month = pesel.Substring(2, 2);
            string day = pesel.Substring(4, 2);
            string DateOfBirth = year + "/" + month + "/" + day;

            return DateOfBirth;
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