using System.Collections.Generic;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Sieradz.SieradzBankTransferTask.SieradzBankUtils;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask
{
    public class SieradzPerformTransfers : PerformTransfers
    {
        protected SieradzGenericInstanceCreator<BankTransfersParser> SGIC_BTP;
        protected SieradzGenericInstanceCreator<TransferHandle> SGIC_TH;

        protected override List<BankTransfersParser> GetAllParsers()
        {
            SGIC_BTP = new SieradzGenericInstanceCreator<BankTransfersParser>();
            return SGIC_BTP.CreateObjectList();
        }

        protected override List<TransferHandle> GetAllHandles()
        {
            SGIC_TH = new SieradzGenericInstanceCreator<TransferHandle>();
            return SGIC_TH.CreateObjectList();
        }

        public override void TransferAll()
        {

            var parsers = GetAllParsers();
            var handles = GetAllHandles();
            if (parsers.Count == 0 || handles.Count == 0) return;
            /*
             * Mamy tutaj trzy pętle i każdą można wywołać jako parallel - w testach musimy sprawdzić które najbardziej opłaca się parallelizować, bo wątpię że wszystkie. Stawiam
             * tylko na Parallel.ForEach(parsers, parser => ... ); bo to największy kawał, będzie tyklko tyle tasków utworzonych ile mamy parserów czyli ze 5-6. Tak czy siak zapisałem
             * na razie wszystkie, jak będziemy mieli wszyscy parsery gotowe to będzie można robić testy i mierzyć czasy
             */
            //Można Przygotować wersję używającą ParalellProcessing i ProcessInParallel jak tu http://puu.sh/iYUDK/f1d6f76442.png
            //foreach (var parser in parsers)
            Parallel.ForEach(parsers, parser =>
            {
                var transfers = parser.GetBankTransfers();

                //foreach (var transfer in transfers)
                Parallel.ForEach(transfers, transfer =>
                {
                    // foreach (var handle in handles)
                    // {
                    //     handle.SendTransfer(transfer);
                    // }
                    Parallel.ForEach(handles, handle =>
                    {
                        handle.SendTransfer(transfer);
                    });
                });

                //odp ktore sie powiodly
            });
        }
    }
}