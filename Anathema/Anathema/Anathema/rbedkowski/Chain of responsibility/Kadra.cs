namespace Anathema.rbedkowski.Chain_of_responsibility
{
    public abstract class Kadra
    {
       
        public string Imie { get; set; } 
        public string Nazwisko { get; set; }

        protected Kadra NextKadra;

        public void SetNext(Kadra kadra)
        {
            NextKadra = kadra;
        }

        public abstract void PodajPozycje(Zadanie.Pozycje pozycja);

    }
}