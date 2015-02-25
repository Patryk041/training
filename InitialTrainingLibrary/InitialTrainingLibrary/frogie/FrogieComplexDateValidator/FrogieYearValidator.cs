using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.frogie.FrogieComplexDateValidator
{
    class FrogieYearValidator
    {
        public bool rokPoprawny(int rok)
        {
            return rok > 0;
        }

        public bool rokPrzestepny(int rok)
        {
            return rok%4 == 0;
        }

    }
}
