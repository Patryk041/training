using System.Collections.Generic;
using Toci.Hornets.Sieradz.HealthCenter.Abstracts;
using Toci.Hornets.Sieradz.HealthCenter.Types;

namespace Toci.Hornets.Sieradz.HealthCenter.Loaders
{
    public class DefaultPatientsLoader : PatientsLoader
    {
        public override List<Patient> LoadPatients()
        {
            var personalData = new PersonalData()
            {
                //Wiek = 42
            };

            var patientHistory = new PatientHistory()
            {
                Historia = "Niewiarygodna historia"
            };

            var patient = new Patient()
            {
                PersonalData = personalData,
                PatientHistory = patientHistory
            };

            return new List<Patient> { patient };
        }
    }
}