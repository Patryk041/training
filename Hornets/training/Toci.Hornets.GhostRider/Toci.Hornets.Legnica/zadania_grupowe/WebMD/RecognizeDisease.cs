using System.Collections.Generic;
using Toci.Hornets.Legnica.zadania_grupowe.WebMD.Data;
using Toci.Hornets.Legnica.zadania_grupowe.WebMD.interfaces;

namespace Toci.Hornets.Legnica.zadania_grupowe.WebMD
{
    public abstract class RecognizeDisease
    {
        protected abstract IEnumerable<PatientInforamtion> GetPatientsInformation();


        protected abstract IEnumerable<IDieseaseRecognizer> GetDiseaseRecognizers();

        public virtual void Recognize()
        {
            foreach (var patientInformation in GetPatientsInformation())
            {
                foreach (var dieseaseRecognizer in GetDiseaseRecognizers())
                {
                    dieseaseRecognizer.Recognize(patientInformation);
                }
            }
        }
    }
}