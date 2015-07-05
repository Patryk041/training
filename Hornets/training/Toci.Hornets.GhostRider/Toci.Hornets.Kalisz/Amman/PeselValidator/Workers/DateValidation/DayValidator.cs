using System.Collections.Generic;

namespace Toci.Hornets.Kalisz.Amman.PeselValidator.Workers.DateValidation
{
    public class DayValidator
    {
        public static bool IsValid(string date)
        {
            var day = int.Parse(date.Substring(0, 2)); //try parse for letters?
            var month = int.Parse(date.Substring(2, 2));

            /* var dayMonthDictionary = new Dictionary<int, int>()
            {
                {1,31}
                2,27
                3,31

            }
            */
            return false;
        }
    }
    }
