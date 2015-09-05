using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.Factories;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir
{
    public class LegnicaPerformTransfers : PerformTransfers
    {
        private BankTransfersParserFactory _parserFactory;
        private TransferHandleFactory _handleFactory;

        public LegnicaPerformTransfers()
        {
            _parserFactory = new BankTransfersParserFactory();
            _handleFactory = new TransferHandleFactory();
        }

        protected override List<BankTransfersParser> GetAllParsers()
        {
            return _parserFactory.GetAllParsers().ToList();
        }

        protected override List<TransferHandle> GetAllHandles()
        {
            return _handleFactory.GetAllHandles().ToList();
        }

        public override void TransferAll()
        {
            foreach (var parser in GetAllParsers())
                SendTransfers(parser.GetBankTransfers());
        }

        private void SendTransfers(IEnumerable<BankTransfer> transfers)
        {
            foreach (var transfer in transfers)
            {
                var handle = _handleFactory.GetTransferHandleByBankName(transfer.DestinationBank);
                if(handle != null)
                    handle.SendTransfer(transfer);
            }
        }
    }
}
