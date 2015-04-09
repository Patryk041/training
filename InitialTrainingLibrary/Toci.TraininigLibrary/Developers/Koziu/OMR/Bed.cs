using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Koziu.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.Koziu.OMR
{
    public class Bed : IBed
    {

        public string Kind { get; set; }
        public int MaxAdults { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string GetSize()
        {
            return "Bed size: " + Width + " " + Height + ".";
        }
             
       
    }
}
