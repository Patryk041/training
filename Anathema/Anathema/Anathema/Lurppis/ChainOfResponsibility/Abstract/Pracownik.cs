namespace Anathema.Lurppis.ChainOfResponsibility.Abstract
{
    public abstract class Pracownik
    {
        public string Imie { get; set; }

        //wskaznik do nastepnego pracownika
        protected Pracownik NastepnyPracownik;

        //Ustawia kolejnosc nastepnego pracownika
        public void UstawKolejnosc(Pracownik pracownik)
        {
            NastepnyPracownik = pracownik;
        }

        // Metoda symulujaca wykonianie zadan
        public abstract void WykonanieZadania(Zadania zadanie);
    }
}