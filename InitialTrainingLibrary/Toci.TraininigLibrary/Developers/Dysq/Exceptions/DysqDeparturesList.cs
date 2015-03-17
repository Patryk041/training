using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm;
using Toci.TraininigLibrary.Developers.Dysq.Exceptions.ErrorsMessages;
using Toci.TraininigLibrary.Developers.Dysq.Exceptions.Helpers;


namespace Toci.TraininigLibrary.Developers.Dysq.Exceptions
{
    public class DysqDeparturesList : DepartureList<DysqDepartureEntity>
    {
        public override bool Add(DysqDepartureEntity element)
        {
            
            if (HelperOfDate.CheckDates(element))
            {
                throw new DysqValidationException(DateError.GetDateMessage("Bad date."),"");
            }

            if (HelperOfDate.CheckDateInterval(this, element))
            {
                throw new DysqValidationException(DateError.GetDateMessage("Date exists."),"");
            }

            if (element.SectionId == 0)
            {
                throw new DysqValidationException(IdError.GetClientIdMessage("Bad Id."),"");
            }

            if (HelperOfStatus.CheckStatus(element))
            {
                throw new DysqValidationException(StatusError.GetStatusMessage("Active status."),"");
            }

            if (HelperOfStatus.CheckStatus(element))
            {
                throw new DysqValidationException(StatusError.GetStatusMessage("Departuring status"),"");
            }


            return true;
        }
    }
}
