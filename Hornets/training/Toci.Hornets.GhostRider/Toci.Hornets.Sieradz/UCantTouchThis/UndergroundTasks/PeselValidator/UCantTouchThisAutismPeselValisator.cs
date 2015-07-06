using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.PeselValidator
{
    public class UCantTouchThisAutismPeselValisator : IPeselValidator
    {
        //normal version coming soon
        //autism not final

        private int[] dateArray = new int[3];

        public bool IsPeselValid(string pesel)
        {
            char[] peselArray = pesel.ToCharArray();
            if (pesel.Length != 11 || ! UCTT_PeselValidatorUtils.IsChecksumOk(peselArray)) return false;
            UCTT_PeselValidatorUtils.GetDateFromPesel(peselArray, dateArray);
            return UCTT_PeselValidatorUtils.ValidateDate(dateArray[0], dateArray[1], dateArray[2]);
        }

        public bool ValidateDate(int year, int month, int day)
        {
            throw new System.NotImplementedException();
        }
    }
}