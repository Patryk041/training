using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Toci.TraininigLibrary.Developers.Koziu.Departure.Helpers
{
    public class FactoryHelper : List<Func<KoziuDepartureEntity, KoziuDepartureList, bool>> 
    {
        public FactoryHelper()
        {
            FactoryDictionary();
        }
        private void FactoryDictionary()
        {    
            Add((x1,x2) => CheckDateHelper.DepartureDateCorrect(x1));
            Add(CheckDateHelper.NoOverlapDateDepartures);
            Add(CheckStatusHelper.CheckStatus);    
        }
           

    }
}
