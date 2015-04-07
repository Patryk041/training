namespace Toci.TraininigLibrary.Developers.RS.Omr.Interfaces
{
    public interface IEmployee
    {
        string CheckIn();
        string CheckOut();
        string DoWork();
        string SetSalary(int newSalary);
    }
}
