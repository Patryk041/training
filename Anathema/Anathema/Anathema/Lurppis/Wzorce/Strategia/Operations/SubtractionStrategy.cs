using Anathema.Lurppis.Wzorce.Strategia.Interface;

namespace Anathema.Lurppis.Wzorce.Strategia.Operations
{
    public class SubtractionStrategy : IStrategy
    {
        public double Calculate(double a, double b)
        {
            return a - b;   
        }
    }
}