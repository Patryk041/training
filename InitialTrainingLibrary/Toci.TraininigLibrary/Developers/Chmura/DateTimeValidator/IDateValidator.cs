namespace Toci.TraininigLibrary.Developers.Chmura.DateTimeValidator
{
    public interface IDateValidator
    {
        bool DateValidate(int year, int month, int day);

        string GetName(); //Zwróćcie swoje imię lub nick
    }
}
