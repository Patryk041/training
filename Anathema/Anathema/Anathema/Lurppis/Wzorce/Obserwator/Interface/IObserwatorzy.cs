namespace Anathema.Lurppis.Wzorce.Obserwator.Interface
{
    public interface IObserwatorzy
    {
        int JakasWlasciwosc { get; set; }

        void DodajObserwator(IObserwator o);

        void UsunObserwator(IObserwator o);

        void PowiadomObserwator();
    }
}