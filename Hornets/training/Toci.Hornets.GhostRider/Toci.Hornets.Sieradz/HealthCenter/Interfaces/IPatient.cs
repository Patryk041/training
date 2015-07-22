using Toci.Hornets.Sieradz.Przychodnia.Types;

namespace Toci.Hornets.Sieradz.Przychodnia.Interfaces
{
    public interface IPatient
    {
        //czy pacjent powinien mieć kalendarz?
        PatientHistory patientHistory { set; get; } 
    }
}