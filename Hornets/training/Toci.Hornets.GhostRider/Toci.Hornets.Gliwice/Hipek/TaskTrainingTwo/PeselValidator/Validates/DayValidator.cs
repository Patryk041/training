using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Gliwice.Hipek.TaskTrainingTwo.PeselValidator.Validates
{
    public static class DayValidator
    {
        private static List<int> _evenMonths = new List<int>
        {
            {4},{6},{9},{11}
        };
        private static List<int> _oddMonths = new List<int>
        {
            {1},{3},{5},{7},{8},{10},{12}
        };
        private static List<int> _februaryMonth = new List<int>
        {
            {2}
        };

        public static bool IsCorrect(int day, int month, bool isLeapYear)
        {
            if (_evenMonths.Contains(month))
                return day >= 1 && day <= 30;
            
            if (_oddMonths.Contains(month))
                return day >= 1 && day <= 31;
            
            if (_februaryMonth.Contains(month))
            {
                if (isLeapYear)
                    return day >= 1 && day <= 29;
                else
                    return day >= 1 && day <= 28;
            }
            return false;
        }
    }
}
