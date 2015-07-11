using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace Toci.Hornets.Kalisz.Adrianowsky94.PeselValidatorHW.PeselManipulationMethods
{
    public class MonthsDict
    {
        public static Dictionary<int, int> monthsDictionary;

        public static Dictionary<int, int> ProperMonthsDict()
        {
            int februaryDays = 28;
            if (Date.IfLeapYear())
                februaryDays++;

            return monthsDictionary = new Dictionary<int, int>()
                {
                    {1, 31},
                    {2, februaryDays},
                    {3, 31},
                    {4, 30},
                    {5, 31},
                    {6, 30},
                    {7, 31},
                    {8, 31},
                    {9, 30},
                    {10, 31},
                    {11, 30},
                    {12, 31}
                };
        }
    }
}