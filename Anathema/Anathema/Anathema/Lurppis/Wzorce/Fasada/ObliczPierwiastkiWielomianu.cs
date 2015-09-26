using System;

namespace Anathema.Lurppis.Wzorce.Fasada
{
    public class ObliczPierwiastkiWielomianu
    {
        public void DeltaDodatnia(double a, double b, double c)
        {
            double delta = b*b - 4.0*a*c;
            Console.WriteLine("Pierwszy pierwiastek: {0}", ((-b - delta)/(2*a)));
            Console.WriteLine("drugi pierwiastek: {0}",((b + delta)/(2*a)));
        }

        public void DeltaZerowa(double a, double b, double c)
        {
            Console.WriteLine("Pierwiastek wynosi: {0}", (-b)/(2*a));
        }

        public void DeltaUjemna(double a, double b, double c)
        {
            Console.WriteLine("brak pierwiastkow ujenych");
        }
    }
}