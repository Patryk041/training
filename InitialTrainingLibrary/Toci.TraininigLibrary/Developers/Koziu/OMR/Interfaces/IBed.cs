using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Koziu.OMR.Interfaces
{
    public interface IBed     {
       
        string Kind {get; set; }
        int MaxAdults { get; set; }
        int Width { get; set; }
        int Height { get; set; }
<<<<<<< HEAD
        string GetSize();  
    }      
=======
        int GetSize();  
    }

    public enum BedKind
    {
        SingleBed,
        DoubleBed,

    }
>>>>>>> be0099251d400d27461618206d512626c8c311a2
}
