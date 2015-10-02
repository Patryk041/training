using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.rbedkowski.Fabryka
{
    class Pizza : IOrder
    {
        public string GetComponent()
        {
            return "Pizza";
        }
    }
}
