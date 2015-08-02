using Toci.Hornets.Sieradz.HealthCenter.Types;

namespace Toci.Hornets.Sieradz.HealthCenter.Interfaces
{
    public interface IPatient : IHuman
    {
        PatientHistory PatientHistory { set; get; } 
    }
}