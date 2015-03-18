using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm;

namespace Toci.TraininigLibrary.Developers.Chmura.ChmuraDeparture
{
    public class ChmuraDepartureEntity : DepartureEntity
    {
        public static int IdCounter = 0;

        public ChmuraDepartureEntity(int clientId, int sectionId, int consultantId, DateTime departureDate, DateTime returnDate)
        {
            this.ClientId = clientId;
            this.SectionId = sectionId;
            this.ConsultantId = consultantId;
            this.DepartureDate = departureDate;
            this.ReturnDate = returnDate;
            this.Id = IdCounter++;
        }

        public override int WeeksCount
        {
            get { return Math.Abs(ReturnDate.Subtract(DepartureDate).Days)/7; }
        }
    }
}
