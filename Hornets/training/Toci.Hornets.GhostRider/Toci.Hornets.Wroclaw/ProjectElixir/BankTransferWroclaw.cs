using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Wroclaw.ProjectElixir
{
    public class BankTransferWroclaw : BankTransfer
    {
            public string SourceBank { get; set; }

            public string DestinyBank { get; set; }

            public bool IsTransferSuccessful { get; set; }

            public int AccountNumber { get; set; }

            public string DestinationName { get; set; }

            public string DestinationAddress { get; set; }

            public DateTime TransactionTime { get; set; }
    }
    
}
