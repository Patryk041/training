using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Employee;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Restaurant;

namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Interfaces
{
    public interface IRestaurant
    {
        List<IEmployee> GetEmployees();
        List<IService> GetService();
        Address GetAddress();
        string GetName();
        string DoWork();
    }
}
