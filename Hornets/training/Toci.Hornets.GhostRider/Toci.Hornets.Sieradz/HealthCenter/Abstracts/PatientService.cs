using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.Sieradz.HealthCenter.Interfaces;
using Toci.Hornets.Sieradz.Toolz;
using Toci.Hornets.Sieradz.HealthCenter.ExtensionMethods;
using Toci.Hornets.Sieradz.HealthCenter.Loaders;

namespace Toci.Hornets.Sieradz.HealthCenter.Abstracts
{
    public class PatientService : IPatientService
    {
        public delegate List<Patient> Loader();

        public List<IPatient> GetPatients()
        {
            return LoadPatients().Select(x => (IPatient)x).ToList();
        }

        private static IEnumerable<PatientsLoader> GetAllLoaders()
        {
            var patientsLoaders = new SieradzGenericInstanceCreator<PatientsLoader>();
            return patientsLoaders.CreateObjectList();
        }

        private static IEnumerable<Patient> LoadPatients()
        {
            var defaultPatientsLoader = new DefaultPatientsLoader();
            var result = GetAllLoaders().SelectMany(x => x.LoadPatients());
            Loader loader = defaultPatientsLoader.LoadPatients;
            loader = loader.FillDelegates(GetAllLoaders());
            return result;
        }
    }
}