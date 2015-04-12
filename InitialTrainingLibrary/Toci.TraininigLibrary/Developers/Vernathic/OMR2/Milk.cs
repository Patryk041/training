using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Vernathic.OMR2
{
    class Milk : Substance
    {
        public bool Frothered { get; set; }

        public Milk() : base()
        {
            MyType = TypeOfSubstance.Milk;
        }
    }
}
