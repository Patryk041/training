using Toci.Hornets.Kalisz.Amman.PeselValidator.Workers;

namespace Toci.Hornets.Kalisz.Amman.PeselValidator
{
    public class AmmanPeselValidator : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            return PeselCutter.Cut(pesel);
        }

        protected override bool Checksum(string pesel)
        {
            return ChksumValidator.Check(pesel);
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            throw new System.NotImplementedException();
        }

        public override string GetNick()
        {
            return "Amman";
        }

        public override bool IsPeselValid(string pesel)
        {
            return PeselValidatorWorker.IsValid(pesel);
        }
    }
}