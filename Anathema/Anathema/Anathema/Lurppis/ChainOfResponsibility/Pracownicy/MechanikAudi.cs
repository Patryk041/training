using System;
using Anathema.Lurppis.ChainOfResponsibility.Abstract;

namespace Anathema.Lurppis.ChainOfResponsibility.Pracownicy
{
    public class MechanikAudi : Pracownik
    {
        public MechanikAudi(string imie)
        {
            Imie = imie;
        }
        public override void WykonanieZadania(Zadania zadanie)
        {
            if (zadanie == Zadania.Audi)
            {
                Console.WriteLine("{0} o imieniu {1} obsluguje zadanie {2}", GetType(), Imie, zadanie);
            }
            else if(zadanie != null)
            {
                NastepnyPracownik.WykonanieZadania(zadanie);
            }
        }
    }
}