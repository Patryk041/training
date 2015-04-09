using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Abstract_Class;

namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Employee
{
    public class Employee : EmployeeBase
    {
        protected const decimal ChefSHours = 50;
        protected const decimal CookSHours = 30;
        protected const decimal MenagerSHours = 60;
        protected const decimal WaiterSHours = 10;
        protected const decimal BarmanSHours = 21;


        public Employee(int id, string fname, string lname) : base(id, fname, lname)
        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
            
        }

        public override decimal GetSalary(KindOfJob koj, int workingHours)
        {
            switch (koj)
            {
                case KindOfJob.Chef:
                    return workingHours* ChefSHours;
                    break;
                case KindOfJob.Cook:
                    return workingHours* CookSHours;
                    break;
                case KindOfJob.Menager:
                    return workingHours* MenagerSHours;
                    break;
                case KindOfJob.Waiter:
                    return workingHours* WaiterSHours;
                    break;
                case KindOfJob.Barman:
                    return workingHours* BarmanSHours;
                    break;
            }
            return 0;
        }
        public override KindOfJob GetPosition()
        {
            return Position;
        }
        public override int GetWorkingHours()
        {
            return WorkingHours;
        }
    }
}
