using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.Factories;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir
{
    class LegnicaPerformTransfers : PerformTransfers
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
            return (List<BankTransfersParser>) _parserFactory.GetAllParsers();
        }

        protected override List<TransferHandle> GetAllHandles()
        {
            return (List<TransferHandle>) _handleFactory.GetAllHandles();
        }


        public override void TransferAll()
        {
            foreach (var parser in GetAllParsers())
                SendTransfers(parser.GetBankTransfers());
                //odp ktore sie powiodly
        }

        private void SendTransfers(IEnumerable<BankTransfer> transfers)
        {
            var handles = GetAllHandles();
            foreach (var transfer in transfers)
            {
                SendTransfer(handles[0],transfer);
                _handleFactory.GetTransfersByPredicate(x => x == transfer.DestinationBank);
                /*handles.Select(x => x.BankName == transfer.DestinationBank);
                 *jezeli da sie zmienic bank Name na wlasciwosc
                 *jezeli nie to poberamy delegatem z fabryki, ale to duzo wiecej czasu zajmie
                 */
            }
        }

        private void SendTransfer(TransferHandle handle, BankTransfer transfer)
        {
            handle.SendTransfer(transfer);
        }
    }
}
