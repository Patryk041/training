using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Koziu.OMR.Interfaces
{
    public interface IClient
    {
        string Login { get; set; }
        string Password { get; set; }
        IContact Contact { get; set; }
        IAddress Address { get; set; }
        string AddPhoto(string path);
        IHotel AddHotel();
        IRoom AddRoom();
        IModule AddModule();

    }
}
