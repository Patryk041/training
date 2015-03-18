using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm;

namespace Toci.TraininigLibrary.Developers.Mg.Departures
{
    public class MgValidationException : Exception
    {
        MgValidationException(string message) : base(message)
        {
            
        }
    }
}
