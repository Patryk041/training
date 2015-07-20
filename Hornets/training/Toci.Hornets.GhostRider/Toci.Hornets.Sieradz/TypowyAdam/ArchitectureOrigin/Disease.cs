using System.Collections.Generic;

namespace Toci.Hornets.Sieradz.TypowyAdam.ArchitectureOrigin
{
    public class Disease
    {
        Dictionary<Symptom, int> SymptomToPropabilityDictionary;
        public PatientData patientProfile; //albo coś analogicznego co by mówiło jaka grupa pacjentów mogła by mieć daną chorobę czyli np - przy bólu brzucha dla faceta rak jajnika jest wykluczony
    }
}