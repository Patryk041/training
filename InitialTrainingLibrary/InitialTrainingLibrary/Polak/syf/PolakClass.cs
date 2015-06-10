using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Polak.syf
{
    public class PolakClass
    {
        private int score = 0;

    }

    class SecondPolakClass
    {
        public int metoda1(int liczba1)
        {
            int wynik = liczba1*PolakClass.score;
            return wynik;
        }

        //nie mozna odwolac sie do prywatnego pola klasy, poza tą klasą.
    }
}
