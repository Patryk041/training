using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.frogie
{
    public class FrogieDateValidator : IDateValidator
    {
        public bool DateValidate(int year, int month, int day)
        {
            if (year < 0)
            {
                return false;
            }
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return validate(day, 31);
                case 4:
                case 6:
                case 9:
                case 11:
                    return validate(day, 30);
                case 2:
                    if (year % 4 == 0)
                    {
                        return validate(day, 29);
                    }
                    else
                    {
                        return validate(day, 28);
                    }
                default:
                    return false;
            }
        }

        private bool validate(int day, int maxDay)
        {
            return day > 0 && day <= maxDay;
        }

        public string GetName()
        {
            return "Frogie 2.0";
        }
    }
}
