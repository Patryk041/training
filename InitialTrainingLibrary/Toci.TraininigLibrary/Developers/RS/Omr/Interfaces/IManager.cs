using Toci.TraininigLibrary.Developers.RS.Omr.Abstract;

namespace Toci.TraininigLibrary.Developers.RS.Omr.Interfaces
{
    public interface IManager
    {
        string SignDocument();
        string DelegateEmployeeToDoJob(EmployeeBase employee);
    }
}
