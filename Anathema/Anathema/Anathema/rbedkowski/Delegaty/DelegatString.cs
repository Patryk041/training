using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.rbedkowski.Delegaty
{
    class DelegatString
    {
        public string Tekst1(string txt)
        {
            return txt.ToUpper();
        }

        public string Tekst2(string txt)
        {
            return txt.ToLower();
        }
    }
}
