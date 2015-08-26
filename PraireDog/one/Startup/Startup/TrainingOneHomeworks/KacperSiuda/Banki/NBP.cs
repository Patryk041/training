using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Startup.Test
{
    public class Nbp : Bank
    {
        public Nbp(string name,int id)
        {
            this.BankId = id;
            this.BankName = name;
        }
        
    }
}
