using Toci.Hornets.Sieradz.Przychodnia.Interfaces;
using Toci.Hornets.Sieradz.Przychodnia.Types;
using Calendar = System.Globalization.Calendar;

namespace Toci.Hornets.Sieradz.Przychodnia.Abstracts
{
    public class Doctor : IDoctor
    {
        public PersonalData personalData { get; set; }
        public string profession { get; set; }
        public Calendar calendar { get; set; }
    }
}