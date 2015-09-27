using Anathema.Lurppis.Wzorce.Dekorator.Interface;

namespace Anathema.Lurppis.Wzorce.Dekorator
{
    public class KalkulatorProsty : IKalkulator
    {
        public string RodzajKalkulatora { get; set; }

        public KalkulatorProsty(string nazwa)
        {
            RodzajKalkulatora = nazwa;
        }

        public double Dodawanie(double a, double b)
        {
            return a + b;
        }

        public double Odejmowanie(double a, double b)
        {
            return a - b;
        }

        public double Mnozenie(double a, double b)
        {
            return a*b;
        }

        public double Dzielenie(double a, double b)
        {
            if (b != 0)
                return a/b;
            return 0;
        }

        public string WyswietlRodzajKalkulatora()
        {
            return RodzajKalkulatora;
        }
    }
}