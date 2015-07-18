using System.Collections.Generic;

namespace Toci.Hornets.GhostRider.Kir
{
    public abstract class PerformTransfers
    {
        public int Test = 0;

        protected abstract List<BankTransfersParser> GetAllParsers();

        protected abstract List<TransferHandle> GetAllHandles();

        public virtual void TransferAll()
        {
            var parsers = GetAllParsers();
            var handles = GetAllHandles();

            foreach (var parser in parsers)
            {
                var transfers = parser.GetBankTransfers();

                foreach (var transfer in transfers)
                {
                    foreach (var handle in handles)
                    {
                        handle.SendTransfer(transfer);
                    }
                }

                //odp ktore sie powiodly
            }
        }
    }
}