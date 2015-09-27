namespace Anathema.Lurppis.Wzorce.Kompozyt.Interface
{
    public interface IKomponent
    {
        int Cena { get; set; }
        string NazwaWyswietlana { get; set; }

        void Dodaj(IKomponent ob);
        void Usun(IKomponent ob);
        void Wyswietl(int przesuniecie);
    }
}