using Toci.Hornets.Sieradz.Przychodnia.Interfaces;
using Toci.Hornets.Sieradz.Przychodnia.Types;

namespace Toci.Hornets.Sieradz.Przychodnia.Abstracts
{
    public class Patient : IPatient
    {
        public PatientHistory patientHistory { get; set; }
    }
}