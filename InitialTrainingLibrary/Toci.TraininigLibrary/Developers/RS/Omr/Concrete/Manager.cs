using System;
using Toci.TraininigLibrary.Developers.RS.Omr.Abstract;
using Toci.TraininigLibrary.Developers.RS.Omr.Interfaces;

namespace Toci.TraininigLibrary.Developers.RS.Omr.Concrete
{
    public class Manager : EmployeeBase, IManager
    {
        public Manager() : base()
        {
        }

        public Manager(int id, string name, string surname, int salary, string jobTitle)
            : base(id, name, surname, salary, jobTitle)
        {
        }

        public string SignDocument()
        {
            return "The document is signed";
        }

        public string DelegateEmployeeToDoJob(EmployeeBase employee)
        {
            return String.Format("{0} {1}, do this job!", employee.Name, employee.Surname);
        }

        public override string DoWork()
        {
            return "Zzzzz (Sleeping)";
        }

        public override string SetSalary(int newSalary)
        {
            Salary = newSalary;
            return String.Format("You earn now {0}.", newSalary);
        }
    }
}
