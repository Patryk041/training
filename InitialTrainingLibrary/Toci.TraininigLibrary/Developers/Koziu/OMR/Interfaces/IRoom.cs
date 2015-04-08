using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Koziu.OMR.Interfaces
{
    public interface IRoom 
    {
        int Number { get; set; }
        bool Status { get; set; }
        
        List<IModule> ModuleList { get; set; }
        List<IBed> BedsList { get; set; }
    }

}
