using System.Collections.Generic;
using Toci.Hornets.Sieradz.HealthCenter.Interfaces;

namespace Toci.Hornets.Sieradz.HealthCenter.Abstracts
{
    public abstract class PatientsLoader
    {
        public abstract List<Patient> LoadPatients();
    }
}