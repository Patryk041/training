using System.Collections.Generic;
using Toci.Hornets.Sieradz.Architektura.Enums;
using Toci.Hornets.Sieradz.TypowyAdam.ArchitectureOrigin;

namespace Toci.Hornets.Sieradz.Architektura.Abstract
{
    public abstract class PatientData
    {
        public int Age;
        public GenderEnum Gender;

        public List<Symptom> PatientSymptoms;
    }
}