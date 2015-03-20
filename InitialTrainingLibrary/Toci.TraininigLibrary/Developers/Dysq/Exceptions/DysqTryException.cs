using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.Exceptions
{
    public class DysqDepartureLogic
    {
        public void DysqDepartureLogicFill()
        {
            
                DysqDeparturesList myTestList = new DysqDeparturesList();

                DysqDepartureEntity entity = new DysqDepartureEntity();
                entity.ClientId = 1;
                entity.DepartureDate = DateTime.Parse("2015-03-16");
                entity.ReturnDate = DateTime.Parse("2015-05-16");
                entity.SectionId = 15;
                entity.StatusId = 1;

                myTestList.Add(entity);
         }
            
     }
}

