using System;

namespace Anathema.rbedkowski.Chain_of_responsibility
{
    public class Trener : Kadra
    {
        public Trener(string imie, string nazwisko)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
        }

        public override void PodajPozycje(Zadanie.Pozycje pozycja)
        {
            if (pozycja == Zadanie.Pozycje.trener)
            {
                Console.WriteLine("{0} o imieniu {1} zajmuje pozycje: {2}",
                    this.GetType().Name, Imie, pozycja);
            }
            else if (NextKadra != null)
            {
                NextKadra.PodajPozycje(pozycja);
            }
        }
    }
}