using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Koziu.Departure.Helpers
{
    static class NumberOfWeeksHelper
    {
        private const int DaysOfWeek = 7;
        public static int NumberOfWeeks(DateTime DepartureDate, DateTime ReturnDate)
        {
            return (int) (ReturnDate - DepartureDate).TotalDays/DaysOfWeek;
        }
    }
}
