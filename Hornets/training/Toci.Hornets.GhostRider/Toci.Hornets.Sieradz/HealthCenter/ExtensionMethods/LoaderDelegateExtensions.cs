using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.Sieradz.HealthCenter.Abstracts;
using Toci.Hornets.Sieradz.HealthCenter.Loaders;

namespace Toci.Hornets.Sieradz.HealthCenter.ExtensionMethods
{
    public static class LoaderDelegateExtensions
    {
        public static PatientService.Loader FillDelegates(this PatientService.Loader loader, IEnumerable<PatientsLoader> loadersList)
        {
            return loadersList.Where(patientLoader => patientLoader.GetType() != typeof (DefaultPatientsLoader)).Aggregate(loader, (current, patientLoader) => current + patientLoader.LoadPatients);
        }
    }
}