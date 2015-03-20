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

        KoziuDepartureEntity(int clientID, int sectionID, int id, DateTime departureDate, DateTime returnDate, int consultantID, int statusID)
        {
            base.ClientId = clientID;
            base.SectionId = sectionID;
            base.Id = id;
            base.DepartureDate = departureDate;
            base.ReturnDate = returnDate;
            base.ConsultantId = consultantID;
            base.StatusId = statusID;     
        }

        public override int WeeksCount
        {
            get { return NumberOfWeeksHelper.NumberOfWeeks(this.ReturnDate, this.DepartureDate); }
        }
    }
}
