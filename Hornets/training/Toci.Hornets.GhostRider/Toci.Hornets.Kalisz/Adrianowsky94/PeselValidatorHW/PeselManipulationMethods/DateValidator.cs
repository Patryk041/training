using Toci.Hornets.GhostRider.ClassObjectStatic;

namespace Toci.Hornets.Kalisz.Adrianowsky94.PeselValidatorHW.PeselManipulationMethods
{
    public class DateValidator
    {
        private static bool ifDayIsProper;

        /*public static int GetNumbers()
        {
            Date.GetYear();
            Date.GetMonth();
            Date.GetDay();
        }*/

        public static bool ValidateMonth(int month)
        {
            return month > 0 && month < 13;
        }

        public static bool ValidateDay(int day)
        {
            MonthsDict.ProperMonthsDict();

            foreach (var days in MonthsDict.monthsDictionary.Values)
            {
                return (day > 0 && day <= days) ? ifDayIsProper = true : ifDayIsProper = false;
            }

            return ifDayIsProper;
        }
    }
}