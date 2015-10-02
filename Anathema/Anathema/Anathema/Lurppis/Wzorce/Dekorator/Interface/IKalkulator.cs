namespace Anathema.Lurppis.Wzorce.Dekorator.Interface
{
    public interface IKalkulator
    {
        string RodzajKalkulatora { get; set; }
        double Dodawanie(double a, double b);
        double Odejmowanie(double a, double b);
        double Mnozenie(double a, double b);
        double Dzielenie(double a, double b);

        string WyswietlRodzajKalkulatora();
    }
}