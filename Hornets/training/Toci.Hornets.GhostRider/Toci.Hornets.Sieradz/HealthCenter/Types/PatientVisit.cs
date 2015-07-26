using Toci.Hornets.Sieradz.HealthCenter.Interfaces;
using Toci.Hornets.Sieradz.Przychodnia.Types;

namespace Toci.Hornets.Sieradz.HealthCenter.Types
{
    public class PatientVisit
    {
        public IDoctor doctor;
        public string visitDescription;
        public ExaminationResults examinationResults;
    }
}