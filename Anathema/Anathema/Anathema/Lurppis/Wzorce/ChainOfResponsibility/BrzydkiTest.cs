using System.Collections.Generic;
using Anathema.Lurppis.Wzorce.ChainOfResponsibility.Abstract;
using Anathema.Lurppis.Wzorce.ChainOfResponsibility.Pracownicy;

namespace Anathema.Lurppis.Wzorce.ChainOfResponsibility
{
    public class BrzydkiTest
    {
        static void Main()
        {
            Pracownik andrzejAudiPracownik = new MechanikAudi("Andrzej");
            Pracownik adamBmwPracownik = new MechanikBmw("Adam");
            Pracownik magdaKierownik = new Kierownik("Magda");
            Pracownik marcinKierownik = new Kierownik("Marcin");

            marcinKierownik.UstawKolejnosc(magdaKierownik);
            magdaKierownik.UstawKolejnosc(adamBmwPracownik);
            adamBmwPracownik.UstawKolejnosc(andrzejAudiPracownik);

            List<Zadania> listaZadania = new List<Zadania>
            {
                Zadania.Audi,
                Zadania.Finanse,
                Zadania.Bmw,
                Zadania.Inne
            };

            foreach (var zadania in listaZadania)
            {
                marcinKierownik.WykonanieZadania(zadania);
            }
        }
        

        
    }
}