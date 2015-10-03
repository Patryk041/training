using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.rbedkowski.Fabryka
{
    class Tea : IOrder
    {
        public string GetComponent()
        {
            return "Tea";
        }

    }
}
