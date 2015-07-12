using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Chojnecki.TrainingTwoPESEL
{
    public class AndrzejPeselValidator : PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            return DateMenger.GetDate(pesel);
        }

        protected override bool Checksum(string pesel)
        {
            return PeselControler.PeselContor(pesel);
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            return DateMenger.DayCheck(year, month, day);
        }

        public override string GetNick()
        {
            return "Andrzej";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11) return false;
            if (Checksum(pesel) == false) return false;
            return ValidateDate(int.Parse(CutOffDate(pesel).Substring(4, 4)),
                int.Parse(CutOffDate(pesel).Substring(2, 2)),
                int.Parse(CutOffDate(pesel).Substring(0, 2)));
        }
    }
}