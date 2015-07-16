using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Legnica.Michał_Zembik.FTPcs
{
    class BankTransfer
    {
        public string DestinationBank { get; set; }

        public string SourceBank { get; set; }

        public bool IsTransferSuccessful { get; set; }
    }
}
