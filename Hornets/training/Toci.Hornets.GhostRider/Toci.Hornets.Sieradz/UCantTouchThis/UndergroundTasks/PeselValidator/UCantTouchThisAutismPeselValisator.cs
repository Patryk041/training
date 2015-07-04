using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.PeselValidator
{
    public class UCantTouchThisAutismPeselValisator : IPeselValidator
    {
        //normal version coming soon
        //autism not final

        private const int upperBoundary = '9' + 1;

        public bool IsPeselValid(string pesel)
        {
            int day, month, year;
            char[] peselArray = pesel.ToCharArray();

            if (!ArePeselDigitsOk(peselArray)) return false;

            GetDateFromPesel(peselArray, out day, out month, out year);

            if (!ValidateDate(year, month, day)) return false;

            return IsChecksumOk(peselArray);
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

            return DateValidatorUtils.IsDateValidAndAutistic(day, month, year);
        }

        private void GetDateFromPesel(char[] peselArray, out int day, out int month, out int year)
        {
            year = (peselArray[0] - '0') * 10 + (peselArray[1] - '0');
            month = (peselArray[2] - '0') * 10 + (peselArray[3] - '0');
            day = (peselArray[4] - '0') * 10 + (peselArray[5] - '0');
        }

        private bool ArePeselDigitsOk(char[] peselArray)
        {
            int numberOfDigits = 0;

            for (int i = 0; i < peselArray.Length; i++)
            {
                numberOfDigits += ((~((peselArray[i] - '0') >> 31) & ((peselArray[i] - upperBoundary) >> 31))) & 1;
            }
            return numberOfDigits == 11 || peselArray.Length != 11;
        }

        private bool IsChecksumOk(char[] peselArray)
        {
            int[] wages = {1,3,7,9,1,3,7,9,1,3,1};
            int checksum = 0;
            for (int i = 0; i < peselArray.Length; i++)
            {
                checksum += peselArray[i] * wages[i];
            }
            return (checksum % 10) == 0;
        }
    }
}