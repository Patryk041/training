using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Chojnecki.TrainingTwoPESEL
{
    public class MyPeselValidator : PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            var myCalendar = new Calendar(pesel);
            return myCalendar.GetDay() + "." + myCalendar.GetMonth() + "." + myCalendar.GetYear();
        }

        protected override bool Checksum(string pesel)
        {
            return PeselControler.PeselContor(pesel);
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            return Calendar.dayCheck(year, month, day);
        }

        public override string GetNick()
        {
            return "Andrzej";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11) return false;
            if (Checksum(pesel) == false) return false;
            return ValidateDate(int.Parse(CutOffDate(pesel).Substring(0, 2)),
                int.Parse(CutOffDate(pesel).Substring(3, 2)),
                int.Parse(CutOffDate(pesel).Substring(6, 2)));
        }
    }
}