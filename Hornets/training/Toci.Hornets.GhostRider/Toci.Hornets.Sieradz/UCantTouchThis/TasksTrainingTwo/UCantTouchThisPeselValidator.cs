using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.PeselValidator;

namespace Toci.Hornets.Sieradz.UCantTouchThis.TasksTrainingTwo
{
    public class UCantTouchThisPeselValidator : PeselValidator
    {
        //Not final
        private int _day, _month, _year;

        private const int DateInPeselLowerBoundaty = 0;
        private const int DateInPeselUpperBoundaty = 6;

        private const int ValidPeselLength = 11;

        private const int YearInPeselLowerBoundary = 0;
        private const int YearInPeselUpperBoundary = 1;
        private const int MonthInPeselLowerBoundary = 2;
        private const int MonthInPeselUpperBoundary = 3;
        private const int DayInPeselLowerBoundary = 4;
        private const int DayInPeselUpperBoundary = 5;



        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length != ValidPeselLength || !Checksum(pesel)) return false;
            ExtractDate(CutOffDate(pesel));
            return ValidateDate(_year, _month, _day);
        }

        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(DateInPeselLowerBoundaty, DateInPeselUpperBoundaty);
        }

        private void ExtractDate(string dateString)
        {
            _year = dateString.TryToGetNumber(YearInPeselLowerBoundary, YearInPeselUpperBoundary);
            _month = dateString.TryToGetNumber(MonthInPeselLowerBoundary, MonthInPeselUpperBoundary);
            _day = dateString.TryToGetNumber(DayInPeselLowerBoundary, DayInPeselUpperBoundary);
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