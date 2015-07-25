using System.Collections.Generic;

namespace Toci.Hornets.Sieradz.TypowyAdam.ArchitectureOrigin
{
    public abstract class PatientData
    {
        public int age;
        public int weight;
        public enum sex
        {
            male,
            female
        };

        public List<Symptom> patientSymptoms;
    }
}