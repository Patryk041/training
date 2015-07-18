using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Agata.Kir
{
    public class YaghaPerformTransfers : Toci.Hornets.GhostRider.Kir.PerformTransfers
    {
        protected override List<BankTransfersParser> GetAllParsers()
        {
            return new List<BankTransfersParser> {new YaghaBankTransferParser()};
        }

        protected override List<TransferHandle> GetAllHandles()
        {
            return new List<TransferHandle> { new YaghaTransferHandle() };
        }
    }
}