using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Koziu.OMR.Interfaces
{
    interface IBed
    {
        string Name { get; set; }
        BedKind kind {get; set; }
        int MaxAdults { get; set; }
        int Widht { get; set; }
        int Height { get; set; }
        int GetSize();  
    }

    public enum BedKind
    {
        SingleBed,
        DoubleBed,

    }
}
