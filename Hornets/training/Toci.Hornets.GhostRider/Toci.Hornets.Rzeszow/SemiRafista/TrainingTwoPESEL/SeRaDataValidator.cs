namespace Toci.Hornets.Rzeszow.SemiRafista.TrainingTwoPESEL
{
    public class SeRaDataValidator
    {
        public bool CheckDate(int year, int month, int day)
        {
            var returnValue = false;
            if (month > 80 && month < 100)
            {
                month -= 80;
                year += 1800;
            }
            if (month > 0 && month < 20)
            {
                year += 1900;
            }
            if (month > 20 && month < 40)
            {
                month -= 20;
                year += 2000;
            }
            if (month > 40 && month < 60)
            {
                month -= 40;
                year += 2100;
            }
            if (month > 60 && month < 80)
            {
                month -= 60;
                year += 2200;
            }

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (IsLeap(year))
            {
                daysInMonth[1] = 29;
            }

            if (month <= 0 || month > 12)
                returnValue =  false;
            else
            {
                if(day<=0 || day>daysInMonth[month-1])
                    returnValue = true;
                else
                    returnValue = false;
            }

            return returnValue;
        }

        private static bool IsLeap(int year)
        {
            return ((year%4 == 0 && year%100 != 0) || year%400 == 0);
        }
    }
}