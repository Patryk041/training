using System;
using System.Collections.Generic;

namespace Toci.TraininigLibrary.Developers.Mg.Departures.Helpers
{
    static class MgDepartureValidationHelpers<T> where T : MgDepartureEntity
    {

        private const int DaysAmountInOneWeek = 7;

        internal static int CountWeeks(MgDepartureEntity entity)
        {
            return (int)((entity.ReturnDate - entity.DepartureDate).TotalDays / DaysAmountInOneWeek);
        }

        internal static void CheckReturnDate(MgDepartureEntity entity)
        {
            if (entity.DepartureDate > entity.ReturnDate) throw new MgValidationException(MgExceptionMessages.DepartureDateIsLaterThanTheReturnDate);
        }

        internal static void CheckDepartureInterval(MgDepartureList<T> list, MgDepartureEntity entity)
        {
          
            foreach (var record in list)
            {
                if (entity.DepartureDate >= record.DepartureDate && entity.ReturnDate <= record.ReturnDate) throw new MgValidationException(MgExceptionMessages.DepartureDateOverlapsTheDateOfReturn);

            }


           
           
        }

        internal static void CheckStatus(MgDepartureList<T> list, MgDepartureEntity entity)
        {
            switch (entity.StatusId)
            {
                case 1:
                    if (entity.DepartureDate < DateTime.Now && entity.ReturnDate < DateTime.Now) throw new MgValidationException(MgExceptionMessages.ThisPersonIsAlreadyBack);
                    break;
                case 2:
                    if (entity.DepartureDate > DateTime.Now.AddDays(7)) throw new MgValidationException(MgExceptionMessages.DpeartureDateIsLongerThanSevenDaysFromNow);
                    break;
                case 3:
                    if (entity.ReturnDate > DateTime.Now) throw new MgValidationException(MgExceptionMessages.ThisPersonIsNotBackYet);

                    break;
        
            }
        }

        internal static void SectionIdCheck(Dictionary<int, List<int>> clientsList, int clientId)
        {
            if (!clientsList.ContainsKey(clientId)) throw new MgValidationException(MgExceptionMessages.SectionIdIsNotValidForThisClientId);
        }
       
    }
}
