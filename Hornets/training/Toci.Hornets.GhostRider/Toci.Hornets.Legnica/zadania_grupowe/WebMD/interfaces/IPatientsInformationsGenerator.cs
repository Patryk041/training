using System.Collections.Generic;
using Toci.Hornets.Legnica.zadania_grupowe.WebMD.Data;

namespace Toci.Hornets.Legnica.zadania_grupowe.WebMD.interfaces
{
    public interface IPatientsInformationsGenerator
    {
        //tutaj podpinamy dostarczanie danych np z pliku, czy bazy danych
        IEnumerable<PatientInforamtion> GetAllPatientsInforamtion(); 
    }
}