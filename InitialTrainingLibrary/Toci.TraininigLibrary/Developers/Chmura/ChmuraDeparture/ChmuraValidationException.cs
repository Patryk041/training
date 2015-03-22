using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm;

namespace Toci.TraininigLibrary.Developers.Chmura.ChmuraDeparture
{
    public class ChmuraValidationException : ValidationException
    {
        public Dictionary<CultureInfo, string> Msg;
        public string OptionalMessage;
        public ChmuraValidationException(Dictionary<CultureInfo, string> message, string optionalMessage = null)
        {
            this.Msg = message;
            this.OptionalMessage = optionalMessage;
        }
    }
}
