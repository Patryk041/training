using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Chmura.ChmuraDeparture
{
    public class ChmuraValidationLoicException : Exception
    {
        public Dictionary<CultureInfo, string> Msg;
        public string OptionalMessage;
        public ChmuraValidationLoicException(Dictionary<CultureInfo, string> message, string optionalMessage = null)
        {
            this.Msg = message;
            this.OptionalMessage = optionalMessage;
        }
    }
}
