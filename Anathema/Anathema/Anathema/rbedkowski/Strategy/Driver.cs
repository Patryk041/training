using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.rbedkowski.Strategy
{
    public class Driver : IAction
    {
        public string GetAction()
        {
            return "Driver";
        }
    }
}
