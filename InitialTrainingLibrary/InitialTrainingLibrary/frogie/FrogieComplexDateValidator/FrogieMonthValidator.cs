using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.frogie.FrogieComplexDateValidator
{
    class FrogieMonthValidator
    {
        Dictionary<int, int> SlownikMiesiac = new Dictionary<int, int>()
        {
            {1,31},
            {3,31},
            {4,30},
            {5,31},
            {6,30},
            {7,31},
            {8,31},
            {9,30},
            {10,31},
            {11,30},
            {12,31},
        };

        public int popdajIloscDni(int miesiac, int rok, FrogieYearValidator validatorRoku)
        {
            if (miesiac == 2 && validatorRoku.rokPrzestepny(rok))
            {
                return 29;
            }
            if (miesiac == 2)
            {
                return 28;
            }
            if (SlownikMiesiac.ContainsKey(miesiac))
            {
                return SlownikMiesiac[miesiac];
            }

            return 0;
        }
    }
}
