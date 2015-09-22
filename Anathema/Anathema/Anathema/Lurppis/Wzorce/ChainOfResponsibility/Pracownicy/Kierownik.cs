using System;
using Anathema.Lurppis.Wzorce.ChainOfResponsibility.Abstract;

namespace Anathema.Lurppis.Wzorce.ChainOfResponsibility.Pracownicy
{
    public class Kierownik : Pracownik
    {
        public Kierownik(string imie)
        {
            Imie = imie;
        }
        public override void WykonanieZadania(Zadania zadanie)
        {
            if (zadanie == Zadania.Finanse)
            {
                Console.WriteLine("{0} o imieniu {1} obsluguje zadanie {2}", GetType(), Imie, zadanie);
            }
            else if (zadanie == Zadania.Inne)
            {
                Console.WriteLine("{0} o imieniu {1} obsluguje zadanie {2}", GetType(), Imie, zadanie);
            }
            else if (zadanie != null)
            {
                NastepnyPracownik.WykonanieZadania(zadanie);
            }
        }
    }
}