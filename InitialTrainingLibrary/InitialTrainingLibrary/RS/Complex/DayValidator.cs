using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.RS.Complex
{
    class DayValidator : IDateValidator
    {
        public bool DateValidate(int year, int month, int day)
        {
            switch (month)
            {
                case 2:
                    if (IsLeapYear(year))
                        return day > 0 && day < 30;
                    else
                        return day > 0 && day < 29;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return day > 0 && day < 32;
                case 4:
                case 6:
                case 9:
                case 11:
                    return day > 0 && day < 31;
                default:
                    return false;
            }
        }

        public string GetName()
        {
            return "Roman Suska";
        }

        private bool IsLeapYear(int year)
        {
            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
        }
    }
}
