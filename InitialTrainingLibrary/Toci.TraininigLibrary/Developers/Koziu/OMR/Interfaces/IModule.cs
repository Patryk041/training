using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Koziu.OMR.Interfaces
{
    /// <summary>
    /// Moduły hotelowe do przyłączenia do hotelu i pokoju (siłownie, restauracje, korty tenioswe, baseny, etc.)
    /// </summary>
    public interface IModule
    {
        string Name { get; set; }
        List<IModule> ModuleList {get; set;}

    }
}
