using Anathema.Lurppis.Wzorce.Dekorator.Interface;

namespace Anathema.Lurppis.Wzorce.Dekorator
{
    public abstract class Dekorator : IKalkulator
    {
        public string RodzajKalkulatora { get; set; }

        protected IKalkulator Kalkulator;

        protected Dekorator(IKalkulator o)
        {
            Kalkulator = o;
        }

        public double Dodawanie(double a, double b)
        {
            return Kalkulator.Dodawanie(a, b);
        }

        public double Odejmowanie(double a, double b)
        {
            return Kalkulator.Odejmowanie(a, b);
        }

        public double Mnozenie(double a, double b)
        {
            return Kalkulator.Mnozenie(a, b);
        }

        public double Dzielenie(double a, double b)
        {
            return Kalkulator.Dzielenie(a, b);
        }

        public string WyswietlRodzajKalkulatora()
        {
            return Kalkulator.WyswietlRodzajKalkulatora();
        }
    }
}