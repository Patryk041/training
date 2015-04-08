using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Koziu.OMR.Interfaces
{
    public interface IHotel
    {
        string Name { get; set; }
        string Description { get; set; }
        int Stars { get; set; }
        IAddress Address { get; set; }     // adres hotelu
        IContact Contact { get; set; }
        void AddPhoto(string path);            
        List<IRoom> RoomsList { get; set; }
        List<IModule> ModuleList { get; set; }

    }
}
