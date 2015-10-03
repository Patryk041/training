using Anathema.Lurppis.Wzorce.Strategia.Interface;

namespace Anathema.Lurppis.Wzorce.Strategia
{
    public class Context
    {
        //  Opcjonalnym elementem całego rozwiązania jest klasa kontekstu,
        //      która sprawi że nasz kod będzie jeszcze bardziej elegancki.
        //      Ideą tej klasy jest utworzenie pośredniej konstrukcji pomiędzy klasami strategii,
        //       a właściwym wywołaniem całego kodu 

        private IStrategy _strategy = null;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public double Calculate(double a, double b)
        {
            return this._strategy.Calculate(a, b);
        }
    }
}