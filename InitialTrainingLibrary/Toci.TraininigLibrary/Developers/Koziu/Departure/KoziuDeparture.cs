using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Koziu.Departure;
using Toci.TraininigLibrary.Developers.Koziu.Departure.Helpers;

namespace Toci.TraininigLibrary.Developers.Koziu
{
    public class KoziuDeparture
    {
        public void test()
        {
            int clientId = 5;
            int sectionId = 6;
            int id = 5;
            DateTime departureDate = DateTime.Now;
            DateTime returnDate = DateTime.Now;
            int consultantID = 5;
            int statusID = 4;
            try
            {
                FactoryHelper fh = new FactoryHelper();  
                KoziuDepartureEntity entity = new KoziuDepartureEntity(clientId, sectionId, id, departureDate, returnDate,consultantID,statusID); 
                KoziuDepartureList list = new KoziuDepartureList();

                foreach (var vare in fh)
                {
                    vare.Invoke(entity,list);
                }
            }
            catch (KoziuValidationException)
            {

                throw new KoziuValidationException("sdas");
            }
            
        }
       
      
    }
}
