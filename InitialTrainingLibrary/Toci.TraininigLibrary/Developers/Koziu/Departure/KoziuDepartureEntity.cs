using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm; 
using Toci.TraininigLibrary.Developers.Koziu.Departure.Helpers;

namespace Toci.TraininigLibrary.Developers.Koziu.Departure
{
    public class KoziuDepartureEntity   : DepartureEntity
    {
        public KoziuDepartureEntity(int clientId, int sectionId, int id, DateTime departureDate, DateTime returnDate, int consultantID, int statusID)
        {
            ClientId = clientId;
            SectionId = sectionId;
            Id = id;
            DepartureDate = departureDate;
            ReturnDate = returnDate;
            ConsultantId = consultantID;
            StatusId = statusID;     
        }

        public override int WeeksCount
        {
            get { return NumberOfWeeksHelper.NumberOfWeeks(this); }
        }
        public bool CheckClientId(int clientId)
        {  
            bool result = false;
            foreach (var entity in ClientsList)
            {
                result = (entity.Key == ClientId);
            }
            return result;
        }
        public bool CheckSectionId(int clientId, int sectionId)
        {             
            bool result = false;
            foreach (var entity in ClientsList)
            {
                foreach (var valueList in entity.Value)
                {
                    result = (valueList == sectionId && entity.Key == clientId);
                }
            }
            return result;
        }
    }
}
