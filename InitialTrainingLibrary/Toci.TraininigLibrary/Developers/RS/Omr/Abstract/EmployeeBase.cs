using System;
using Toci.TraininigLibrary.Developers.RS.Omr.Interfaces;

namespace Toci.TraininigLibrary.Developers.RS.Omr.Abstract
{
    public abstract class EmployeeBase : IEmployee
    {
        #region Constructors

        protected EmployeeBase() : this(0, "Anonymous", "Anonymous", 0, "Not Set")
        {
        }

        protected EmployeeBase(int id, string name, string surname, int salary, string jobTitle)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Salary = salary;
            JobTitle = jobTitle;
        }

        #endregion

        #region Properties

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; protected set; }
        public string JobTitle { get; set; }

        #endregion

        #region Public Methods

        public virtual string CheckIn()
        {
            return String.Format("Employee {0} {1} has checked in.", Name, Surname);
        }

        public virtual string CheckOut()
        {
            return String.Format("Employee {0} {1} has checked out.", Name, Surname);
        }

        public virtual string DoWork()
        {
            return "Doing my Job";
        }

        public abstract string SetSalary(int newSalary);

        #endregion
    }
}
