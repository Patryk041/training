using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.rbedkowski.Strategy
{
    class Sailor : IAction
    {
        public string GetAction()
        {
            return "Sailor";
        }
    }
}
