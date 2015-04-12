using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Employee;

namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Interfaces
{
    public interface IEmployee
    {
        decimal GetSalary(KindOfJob koj, int workingHours);
        KindOfJob GetPosition();
        int GetWorkingHours();
    }
}
