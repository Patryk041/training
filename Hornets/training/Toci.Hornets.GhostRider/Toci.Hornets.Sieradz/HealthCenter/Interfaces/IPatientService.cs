using System.Collections.Generic;
using Toci.Hornets.Sieradz.HealthCenter.Abstracts;

namespace Toci.Hornets.Sieradz.HealthCenter.Interfaces
{
    public interface IPatientService
    {
        List<IPatient> GetPatients();
    }
}