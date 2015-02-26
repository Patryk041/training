using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.RS.Simple
{
    public class DateValidator : IDateValidator
    {
        private int _day;
        private int _month;
        private int _year;

        public bool DateValidate(int year, int month, int day)
        {
            _day = day;
            _month = month;
            _year = year;

            return IsYearValid() && IsMonthValid() && IsDayValid();
        }

        public string GetName()
        {
            return "Roman Suska";
        }

        private bool IsLeapYear()
        {
            return ((_year % 4 == 0 && _year % 100 != 0) || _year % 400 == 0);
        }

        private bool IsYearValid()
        {
            return _year >= 0;
        }

        private bool IsMonthValid()
        {
            return _month > 0 && _month < 13;
        }

        private bool IsDayValid()
        {
            switch (_month)
            {
                case 2:
                    if(IsLeapYear())
                        return _day > 0 && _day < 30;
                    else
                        return _day > 0 && _day < 29;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return _day > 0 && _day < 32;
                case 4:
                case 6:
                case 9:
                case 11:
                    return _day > 0 && _day < 31;
                default:
                    return false;
            }
        }
    }
}
