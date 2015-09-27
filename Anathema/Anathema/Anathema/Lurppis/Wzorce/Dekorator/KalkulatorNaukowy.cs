using System;
using Anathema.Lurppis.Wzorce.Dekorator.Interface;

namespace Anathema.Lurppis.Wzorce.Dekorator
{
    public class KalkulatorNaukowy : Dekorator
    {
        public KalkulatorNaukowy(IKalkulator o, string nazwa) : base(o)
        {
            RodzajKalkulatora = nazwa;
        }

        public double PierwiastekStopnia2(double a) => a < 0 ? 0 : Math.Sqrt(a);
        /*
            if(a<0)
                return 0;
            return Math.sqrt(a);
        */
    }
}