using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.frogie.FrogieComplexDateValidator
{
    public class FrogieDayValidator 
    {
        public bool Validate(int year, int month, int day)
        {
            FrogieYearValidator rok = new FrogieYearValidator();
            FrogieMonthValidator miesiac = new FrogieMonthValidator();
            int maxIloscDni = miesiac.popdajIloscDni(month, year, rok);
            return day >= 1 && day <= maxIloscDni && rok.rokPoprawny(year);
        }
    }
}
