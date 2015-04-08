using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Employee.Employees;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Employee
{
    public static class EmployeeFactory
    {
        private static Dictionary<KindOfJob, Func<int, string, string, IEmployee>> employee = new Dictionary<KindOfJob, Func<int, string, string, IEmployee>>()
        {
            {KindOfJob.Cook,(id,firstname,lastname)=> new Cook(id,firstname,lastname) },
            {KindOfJob.Chef,(id,firstname,lastname)=> new Chef(id,firstname,lastname) },
            {KindOfJob.Menager,(id,firstname,lastname)=> new Menager(id,firstname,lastname) },
            {KindOfJob.Barman,(id,firstname,lastname)=> new Barman(id,firstname,lastname) },
            {KindOfJob.Waiter,(id,firstname,lastname)=> new Waiter(id,firstname,lastname) }
            
        };

        public static IEmployee CreateFigure(KindOfJob kind, int id, string firstname, string lastname)
        {
            return employee[kind](id, firstname, lastname);
        }
    }
}
