using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.TrainingFour.Exceptions
{
    public class DeparturesList : List<Departures>
    {
        public new bool Add(Departures departure)
        {
            if (departure.DateOfDeparture > departure.DateOfReturn)
            {
                //return false;
                throw  new WarriorExceptionBase("daty zachodza na siebie", "");
            }

            if (this.Where(item => item.DateOfDeparture == departure.DateOfDeparture).Count() > 0)
            {
                return false;
            }
            return true;
        }
    }
}
