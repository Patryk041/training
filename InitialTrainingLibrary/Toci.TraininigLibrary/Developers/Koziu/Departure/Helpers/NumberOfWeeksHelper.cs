using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Koziu.Departure.Helpers
{
    public static class NumberOfWeeksHelper
    {
        private const int DaysOfWeek = 7;
        public static int NumberOfWeeks(KoziuDepartureEntity entity)
        {
            return (int) (entity.ReturnDate - entity.DepartureDate).TotalDays/DaysOfWeek;
        }
    }
}
