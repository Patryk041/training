using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm;

namespace Toci.TraininigLibrary.Developers.Dysq.Exceptions
{
    public class DysqValidationException : ValidationException
    {
        public DysqValidationException(string customMessage, string internalMessage)
        {
        }
    }
}
