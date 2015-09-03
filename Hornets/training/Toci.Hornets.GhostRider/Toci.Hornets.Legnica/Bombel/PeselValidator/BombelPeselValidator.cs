using Toci.Hornets.Legnica.Bombel.PeselValidator.DateValidator;

namespace Toci.Hornets.Legnica.Bombel.PeselValidator
{
    public class BombelPeselValidator : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        protected const int LengthOfDate = 6;
        protected const int PeselLength = 11;

        private int _year;
        private int _month;
        private int _day;

        private int[] _elements = new int[10];
        private int[] _weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 0 };



        protected override string CutOffDate(string pesel)
        {
            return pesel.Length >= LengthOfDate ? pesel.Substring(0, LengthOfDate) : "Error. Pesel too short";
        }

        protected override bool Checksum(string pesel)
        {
            if (pesel.Length != PeselLength) return false;
            var checkDigit = pesel.Substring(10, 1);
            var checkSum = 0;

            for (var i = 0; i < 10; i++)
            {
                if (!int.TryParse(pesel[i].ToString(), out _elements[i])) return false;
                checkSum += _weights[i] * _elements[i];
            }

            checkSum %= 10;
            if (checkSum != 0) checkSum = 10 - checkSum;
            return (checkSum.ToString() == checkDigit);
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            return DayValidator.ValidDay(day, month, year) && MonthValidator.ValidMonth(month) &&
                   YearValidator.ValidYear(year);
        }

        public override string GetNick()
        {
            return "Bombel";
        }

        public override bool IsPeselValid(string pesel)
        {
            GetDate(CutOffDate(pesel));
            return Checksum(pesel) && ValidateDate(_year, _month, _day);
        }

        protected void GetDate(string date)
        {
            _year = int.Parse(date.Substring(0, 2));
            _month = int.Parse(date.Substring(2, 2));
            _day = int.Parse(date.Substring(4, 2));

            if (_month > 80 && _month < 93)
            {
                _year += 1800;
                _month -= 80;
            }
            else if (_month > 0 && _month < 13)
            {
                _year += 1900;
            }
            else if (_month > 20 && _month < 33)
            {
                _year += 2000;
                _month -= 20;
            }
            else if (_month > 40 && _month < 53)
            {
                _year += 2100;
                _month -= 40;
            }
            else if (_month > 60 && _month < 73)
            {
                _year += 2200;
                _month -= 60;
            }
        }
    }
}