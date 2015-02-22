using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.frogie
{
    public class FrogieDateValidator : IDateValidator
    {
        // celowo robimy konflikt
        public bool DateValidate(int year, int month, int day)
        {
            if (
                Validate_2(day, month, year) ||
                Validate_30(day, month) ||
                Validate_31(day, month))
            {
                return true;
            }
            return false;
        }

        public string GetName()
        {

            return "frogie";
        }

        private bool Validate_31(int day, int month)
        {
            if (day <= 31 && (month == 1 || month == 3 || month == 5 || month == 7 || month==8 ||month==10||month==12))
            {
                return true;
            }
            
            return false;

        }
        private bool Validate_30(int day, int month)
        {
            if (day <= 30 && (month == 4 || month == 6 || month == 9 || month == 11))
            {
                return true;
            }
          
            return false;

        }

        private bool Validate_2(int day, int month, int year)
        {
            if (day <= 28 && month == 2 && year %4 !=0)
            {
                return true;
            }
            if (day <= 29 && month == 2 && year % 4 == 0)
            {
                return true;
            }

            return false;

        }
    }
}
