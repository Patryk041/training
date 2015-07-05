using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.PeselValidator
{
    public class UCantTouchThisAutismPeselValisator : IPeselValidator
    {
        //normal version coming soon
        //autism not final

        private int _day, _month, _year;

        private const int UpperBoundary = '9' + 1;

        public bool IsPeselValid(string pesel)
        {
            char[] peselArray = pesel.ToCharArray();
            if (pesel.Length != 11 || ! UCTT_PeselValidatorUtils.IsChecksumOk(peselArray)) return false;
            GetDateFromPesel(peselArray);
            return ValidateDate(_year, _month, _day);
        }

        public bool ValidateDate(int year, int month, int day)
        {
            if (month > 80)
            {
                month -= 80;
                year += 1800;
            }
            else if (month > 60)
            {
                month -= 60;
                year += 2200;
            }
            else if (month > 40)
            {
                month -= 40;
                year += 2100;
            }
            else if (month > 20)
            {
                month -= 20;
                year += 2000;
            }
            else
            {
                year += 1900;
            }

            return UCTT_PeselValidatorUtils.IsDateValid(day, month, year);
        }

        private void GetDateFromPesel(char[] peselArray)
        {
            _year = (peselArray[0] - '0') * 10 + (peselArray[1] - '0');
            _month = (peselArray[2] - '0') * 10 + (peselArray[3] - '0');
            _day = (peselArray[4] - '0') * 10 + (peselArray[5] - '0');
        }
    }
}