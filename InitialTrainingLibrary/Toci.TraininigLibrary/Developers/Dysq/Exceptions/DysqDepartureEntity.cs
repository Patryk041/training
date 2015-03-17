using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm;
using Toci.TraininigLibrary.Developers.Dysq.Exceptions.Helpers;

namespace Toci.TraininigLibrary.Developers.Dysq.Exceptions
{
    public class DysqDepartureEntity : DepartureEntity
    {
        public override int SectionId
        {
            get
            {
                return base.SectionId;
            }
            set
            {
                if (!CheckSectionId()) { base.SectionId = 0; } base.SectionId = value;
            }
        }

        public override int WeeksCount
        {
            get
            {
                return NumberOfWeeks.CalculateNumberOfWeeks(this.ReturnDate, this.DepartureDate);
            }
        }

        private bool CheckSectionId()
        {
            if (!ClientsList.ContainsKey(ClientId)) throw new Exception("Id doesn't exist on the list.");

            return ClientsList[ClientId].Contains(SectionId);
        }
    }
}
