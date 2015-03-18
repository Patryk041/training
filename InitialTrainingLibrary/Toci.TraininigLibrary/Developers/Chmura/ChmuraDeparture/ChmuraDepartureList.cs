using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm;
using Toci.TraininigLibrary.Developers.Chmura.Common;

namespace Toci.TraininigLibrary.Developers.Chmura.ChmuraDeparture
{
    public class ChmuraDepartureList : DepartureList<ChmuraDepartureEntity>
    {
        public override bool Add(ChmuraDepartureEntity element)
        {
            try
            {
                CheckDates(element.DepartureDate, element.ReturnDate);
            }
            catch (ChmuraValidationException ex)
            {
                ex.Message.ChmuraWriteErrorToLog();
                ex.StackTrace.ChmuraWriteErrorToLog();
            }

            base.Add(element);

            return true;
        }

        private void CheckDates(DateTime d1, DateTime d2)
        {
            try
            {
                if (d1 > d2)
                {
                    throw new ChmuraValidationException(ChmuraExceptionMessages.ReturnBeforeDepartureEx);
                }
            }
            catch (ChmuraValidationException ex)
            {
                ex.Message.ChmuraWriteErrorToLog();
                ex.StackTrace.ChmuraWriteErrorToLog();
            }
            
            if (
                this.FirstOrDefault(element => (element.DepartureDate <= d1 && element.ReturnDate >= d2) ||
                                               (element.DepartureDate >= d1 && element.ReturnDate <= d2) ||
                                               (element.DepartureDate >= d1 && element.ReturnDate <= d2)) != null
                )
            {
                throw new ChmuraOverlapsException(ChmuraExceptionMessages.DateOverlaps);
            }
        }

    }
}
