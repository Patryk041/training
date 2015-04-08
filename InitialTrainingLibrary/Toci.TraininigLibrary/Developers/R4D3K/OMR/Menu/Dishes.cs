using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Menu
{
    public class Dishes : IDishes
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        private KindOfDishes Kind { get; set; }

    }
}
