using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm;
using Toci.TraininigLibrary.Developers.Mg.Departures.Helpers;

namespace Toci.TraininigLibrary.Developers.Mg.Departures
{
    public class MgDepartureList<T> : DepartureList<T> where T : MgDepartureEntity
    {
        public override bool Add(T element)
        {
            
            MgDepartureValidationHelpers<T>.CheckReturnDate(element);
            MgDepartureValidationHelpers<T>.CheckDepartureInterval(this,element);


            return true;
        }
    }
}
