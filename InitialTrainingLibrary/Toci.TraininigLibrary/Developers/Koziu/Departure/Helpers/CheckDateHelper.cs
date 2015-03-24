using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Koziu.Departure.Helpers
{
    public static class CheckDateHelper
    {
        public static bool DepartureDateCorrect(KoziuDepartureEntity entity)
        {
            return (entity.DepartureDate <= entity.ReturnDate);
        }

        public static bool NoOverlapDateDepartures(KoziuDepartureEntity departure, KoziuDepartureList departuresList)
        {
            bool result = true;
            foreach (var entity in departuresList)
            {
                if((departure.ReturnDate <= entity.DepartureDate) || (departure.DepartureDate >= entity.ReturnDate)) result = false; 
            }
            return result;
        }      
      


    }
}
