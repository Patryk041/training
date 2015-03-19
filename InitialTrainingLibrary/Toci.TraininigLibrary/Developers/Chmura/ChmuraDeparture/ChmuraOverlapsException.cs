using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Chmura.ChmuraDeparture
{
    public class ChmuraOverlapsException : Exception
    {
        private Dictionary<CultureInfo, string> _message;
        protected ChmuraOverlapsException()
        {            
        }
        protected ChmuraOverlapsException(string message):base(message)
        {
        }
        public ChmuraOverlapsException(Dictionary<CultureInfo, string> message)
        {
            this._message = message;
        }
    }
}
