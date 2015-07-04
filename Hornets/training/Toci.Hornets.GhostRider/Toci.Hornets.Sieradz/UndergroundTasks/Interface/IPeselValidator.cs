namespace Toci.Hornets.Sieradz.Undergroun1Task.Interface
{
    public interface IPeselValidator
    {
        bool IsPeselValid(string pesel); //validuje date, liczy sume kontrolną i to co trzeba do pesela
        bool ValidateDate(int year, int month, int day); //do użycia w IsPeselValid
    }
}