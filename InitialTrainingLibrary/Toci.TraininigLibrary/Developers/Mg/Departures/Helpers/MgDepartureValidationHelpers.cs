using System;
using System.Collections.Generic;

namespace Toci.TraininigLibrary.Developers.Mg.Departures.Helpers
{
    static class MgDepartureValidationHelpers<T> where T : MgDepartureEntity
    {
       
        private const int DaysAmountInOneWeek = 7;

        public static int CountWeeks(MgDepartureEntity element)
        {
            return (int)((element.ReturnDate - element.DepartureDate).TotalDays / DaysAmountInOneWeek);
        }

        public static void CheckReturnDate(MgDepartureEntity entity)
        {   
            if(entity.DepartureDate > entity.ReturnDate) throw new Exception("wyjadz później niż powrót");
        }

        public static void CheckDepartureInterval(MgDepartureList<T> list, MgDepartureEntity entity)
        {
          
            foreach (var record in list)
            {
                if (entity.DepartureDate >= record.DepartureDate && entity.ReturnDate <= record.ReturnDate) throw new Exception("daty zachodzą na siebie");

            }


           
           
        }

        public static void CheckStatus(MgDepartureList<T> list, MgDepartureEntity entity)
        {
            switch (entity.StatusId)
            {
                case 1:
                    if (entity.DepartureDate < DateTime.Now && entity.ReturnDate < DateTime.Now) throw new Exception("człowiek już wrócił");
                    break;
                case 2:
                    if (entity.DepartureDate > DateTime.Now.AddDays(7)) throw new Exception("wyjazd ja więcej niż 7 dni");
                    break;
                case 3:
                    if (entity.ReturnDate > DateTime.Now) throw new Exception("nie powrócił jescze");

                    break;
                case 4:

                    break;
            }
        }

        public static void SectionIdCheck(Dictionary<int, List<int>> clientsList, int clientId)
        {
            if (!clientsList.ContainsKey(clientId)) throw new Exception("to id nie może być w tej sekcji");
        }
       
    }
}
