using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Koziu.OMR.Interfaces
{
    public interface IAddress
    {
        string StreetName { get; set; }
        string StreetNumber { get; set; }
        string City { get; set; }
        string Province { get; set; }
        string ZipCode { get; set; }
        string Country { get; set; }

    }
}
