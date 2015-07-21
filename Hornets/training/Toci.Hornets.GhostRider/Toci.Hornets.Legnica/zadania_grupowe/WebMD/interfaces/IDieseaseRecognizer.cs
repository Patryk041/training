using Toci.Hornets.Legnica.zadania_grupowe.WebMD.Data;

namespace Toci.Hornets.Legnica.zadania_grupowe.WebMD.interfaces
{
    public interface IDieseaseRecognizer
    {
        /*nie wiem, czy klasa implementujaca powinna zwracac wykryta 
         * chorobe, czy sama cos z tym robic. Zostawiam tak ze wzgledu 
         * na to, ze po wykryciu choroby mozemy np sprawdzic, ktory najblizszy
         * szpital ma wolne miejsce, lub ktora apteka ma wymagane lekarstwa
         */
        void Recognize(PatientInforamtion patientInforamtion); 
    }
}