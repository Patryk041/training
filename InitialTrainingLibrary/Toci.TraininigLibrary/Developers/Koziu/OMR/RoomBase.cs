using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Koziu.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.Koziu.OMR
{
    public abstract class RoomBase : IRoom
    {
        List<IModule> modules;
        List<IBed> beds;

        public int Number { get; set; }
        public bool Status { get; set; }
       
    }
}
