using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.TrainingFour.Exceptions
{
    public class Departures
    {
        public DateTime DateOfDeparture { get; set; }
        public DateTime DateOfReturn { get; set; }

        public int NumberOfWeeks
        {
            get
            {
                return 0;
            }
        }

        public string Name { get; set; }
    }
}
