using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Koziu.OMR.Interfaces
{
    public interface IContact
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Phone { get; set; }
        string Email { get; set; }                 
    }
}
