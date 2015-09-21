namespace Anathema.Lurppis.Fasada
{
    public class Fasada
    {
        public void ObliczPieriwastkekwielomianu(double a, double b, double c)
        {
            double delta = b*b - 4.0*a*c;
            ObliczPierwiastkiWielomianu opw = new ObliczPierwiastkiWielomianu();
            if (delta > 0)
            {
                opw.DeltaDodatnia(a,b,c);
            }
            else if (delta < 0.0)
            {
                opw.DeltaUjemna(a,b,c);
            }
            else
            {
                opw.DeltaZerowa(a,b,c);
            }
        } 
    }
}