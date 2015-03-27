using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Common.Eacrm
{
    public abstract class ValidationException : Exception
    {
        protected ValidationException()
        {
            
        }

        protected ValidationException(string message):base(message)
        {

        }
    }
}
