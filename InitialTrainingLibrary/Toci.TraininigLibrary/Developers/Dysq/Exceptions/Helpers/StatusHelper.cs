using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.Exceptions.Helpers
{
    public static class StatusHelper
    {
        public static bool CheckStatus(DysqDepartureEntity entity)
        {
            bool status = true;

            switch (entity.StatusId)
            {
                case 1:
                    if (entity.DepartureDate < DateTime.Now && entity.DepartureDate > DateTime.Now)
                        status = false;
                    break;

                case 2:
                    if (entity.DepartureDate <= DateTime.Now.AddDays(7))
                        status = false;
                    break;

                case 3:
                    if (entity.ReturnDate > DateTime.Now)
                        status = false;
                    break;
            }


            return status;
        }
    }
}
