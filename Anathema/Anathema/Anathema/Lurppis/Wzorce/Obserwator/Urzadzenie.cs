using System;
using Anathema.Lurppis.Wzorce.Obserwator.Interface;

namespace Anathema.Lurppis.Wzorce.Obserwator
{
    public class Urzadzenie : IObserwator
    {
        private int _pobranaTemperatura;

        //referencje do obserwowanego obiektu
        private Czujnik _czujnikTemperatury;

        // Wraz z definicja obiektu przypisujemy mu jakis czujnik

        public Urzadzenie(Czujnik o)
        {
            _czujnikTemperatury = o;
        }

        //metoda pobierania temperatury
        public void AktualizacjaDanych()
        {
            _pobranaTemperatura = _czujnikTemperatury.PobierzTemperature();
            Console.WriteLine("Obiekt pobral temperature {0}", _pobranaTemperatura);
        }
    }
}