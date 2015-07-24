using Toci.Hornets.Sieradz.HealthCenter.Interfaces;
using Toci.Hornets.Sieradz.HealthCenter.Types;
using Toci.Hornets.Sieradz.Przychodnia.Types;
using Calendar = System.Globalization.Calendar;

namespace Toci.Hornets.Sieradz.HealthCenter.Abstracts
{
    public class Doctor : IDoctor
    {
        public string profession { get; set; }
        public Calendar calendar { get; set; }
        public PersonalData PersonalData { get; set; }
    }
}