using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm;
using Toci.TraininigLibrary.Developers.Mg.Departures.Helpers;

namespace Toci.TraininigLibrary.Developers.Mg.Departures
{
    public class MgDepartureEntity : DepartureEntity
    {
        
        public override int WeeksCount
        {
            get { return MgDepartureValidationHelpers<MgDepartureEntity>.CountWeeks(this); }
        }

        public override int SectionId
        {
            get { return base.SectionId; }
            set
            {
                MgDepartureValidationHelpers<MgDepartureEntity>.SectionIdCheck(ClientsList,ClientId);
                
                base.SectionId = value;
            }
           
        }

       
    }
}
