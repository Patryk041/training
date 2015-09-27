using System;
using Anathema.Lurppis.Wzorce.Kompozyt.Interface;

namespace Anathema.Lurppis.Wzorce.Kompozyt
{
    class Przeglad : IKomponent
    {
        public int Cena { get; set; }
        public string NazwaWyswietlana { get; set; }

        public Przeglad(string nazwa)
        {
            NazwaWyswietlana = nazwa;
            Cena = 40;
        }

        public void Dodaj(IKomponent ob)
        {
            Console.WriteLine("Niedostępne dla tego elementu.");
        }

        public void Usun(IKomponent ob)
        {
            Console.WriteLine("Niedostępne dla tego elementu.");
        }

        public void Wyswietl(int przesuniecie)
        {
            Console.WriteLine(new String('-', przesuniecie) + String.Format("{0} : Cena {1} zł", NazwaWyswietlana, Cena));
        }
    }
}