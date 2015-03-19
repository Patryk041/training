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
        private Dictionary<CultureInfo, string> _message;
        public ChmuraValidationException(Dictionary<CultureInfo, string> message)
        {
            this._message = message;
        }
    }
}
