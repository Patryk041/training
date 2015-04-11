using System;
using Toci.TraininigLibrary.Developers.RS.Omr.Abstract;

namespace Toci.TraininigLibrary.Developers.RS.Omr.Concrete
{
    public class RegularEmployee : EmployeeBase
    {
        private const string NewSalaryAgreementMessage = "The amount of money is alright.";
        private const string NewSalaryDeclineMessage = "It's too much for a regular employee.";

        public RegularEmployee() : base()
        {
        }

        public RegularEmployee(int id, string name, string surname, int salary, string jobTitle)
            : base(id, name, surname, salary, jobTitle)
        {
        }

        public string MakeComplain(Manager badManager)
        {
            return String.Format("{0} {1}, you're a bad manager!", badManager.Name, badManager.Surname);
        }

        public override string SetSalary(int newSalary)
        {
            return CheckAmountOfMoney(newSalary) ? NewSalaryAgreementMessage : NewSalaryDeclineMessage;
        }

        private bool CheckAmountOfMoney(int amount)
        {
            if (amount > 3000)
            {
                return false;
            }
            Salary = amount;
            return true;
        }
    }
}
