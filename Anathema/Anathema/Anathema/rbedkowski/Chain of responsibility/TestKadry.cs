using System.Collections.Generic;
using Anathema.Lurppis.Wzorce.ChainOfResponsibility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anathema.rbedkowski.Chain_of_responsibility
{
    [TestClass]
    public class TestKadry
    {
        [TestMethod]
        public void Main()
        {
            Kadra obronca = new Obronca("Mateusz", "Bedkowski");
            Kadra bramkarz = new Bramkarz ("Bartlomiej", "Bedkowski");
            Kadra kierownik = new Kierownik("Dariusz", "Machalski");
            Kadra trener = new Trener("Dawid", "Szwarga");

            obronca.SetNext(bramkarz);
            bramkarz.SetNext(kierownik);
            kierownik.SetNext(trener);

            List<Zadanie.Pozycje> pozycja = new List<Zadanie.Pozycje> {
                Zadanie.Pozycje.obronca,
                Zadanie.Pozycje.bramkarz,
                Zadanie.Pozycje.kierownik,
                Zadanie.Pozycje.trener
            };

            foreach (var t in pozycja)
            {
                obronca.PodajPozycje(t);
            }

        }
    }
}