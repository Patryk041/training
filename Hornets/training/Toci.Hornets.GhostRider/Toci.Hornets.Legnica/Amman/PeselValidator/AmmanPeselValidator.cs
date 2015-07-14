using Toci.Hornets.Legnica.Amman.PeselValidator.Workers;

namespace Toci.Hornets.Legnica.Amman.PeselValidator
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
            return DateValidator.IsValid(day, month, year);
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