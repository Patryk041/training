using System;
using Anathema.Lurppis.Wzorce.ChainOfResponsibility.Abstract;

namespace Anathema.Lurppis.Wzorce.ChainOfResponsibility.Pracownicy
{
    public class MechanikBmw : Pracownik
    {
        public MechanikBmw(string imie)
        {
            Imie = imie;
        }
        public override void WykonanieZadania(Zadania zadanie)
        {
            if (zadanie == Zadania.Bmw)
            {
                Console.WriteLine("{0} o imieniu {1} obsluguje zadanie {2}", this.GetType(), Imie, zadanie);
            }
            else if (zadanie != null)
            {
                NastepnyPracownik.WykonanieZadania(zadanie);
            }
        }
    }
}