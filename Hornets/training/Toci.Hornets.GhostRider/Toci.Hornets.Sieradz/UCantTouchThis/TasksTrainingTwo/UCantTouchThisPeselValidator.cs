using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.PeselValidator;

namespace Toci.Hornets.Sieradz.UCantTouchThis.TasksTrainingTwo
{
    public class UCantTouchThisPeselValidator : PeselValidator
    {
        //Not final
        private int _day, _month, _year;

        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11 || !Checksum(pesel)) return false;
            ExtractDate(CutOffDate(pesel));
            return ValidateDate(_year, _month, _day);
        }

        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0, 6);
        }

        private void ExtractDate(string dateString)
        {
            _year = dateString.TryToGetNumber(0, 1);
            _month = dateString.TryToGetNumber(2, 3);
            _day = dateString.TryToGetNumber(4, 5);
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            return UCTT_PeselValidatorUtils.ValidateDate(year, month, day);
        }

        protected override bool Checksum(string pesel)
        {
            return UCTT_PeselValidatorUtils.IsChecksumOk(pesel.ToCharArray());
        }

        public override string GetNick()
        {
            return "UCantTouchThis";
        }
    }
}