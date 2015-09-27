using Anathema.Lurppis.Wzorce.Strategia.Interface;

namespace Anathema.Lurppis.Wzorce.Strategia.Operations
{
    public class DivisionStrategy : IStrategy
    {
        public double Calculate(double a, double b)
        {
            return a/b;
        }
    }
}