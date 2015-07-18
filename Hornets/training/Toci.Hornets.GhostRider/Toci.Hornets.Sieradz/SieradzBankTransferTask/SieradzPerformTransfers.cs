using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Sieradz.SieradzBankTransferTask.SieradzBankUtils;
using Toci.Hornets.Sieradz.Toolz;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask
{
    public class SieradzPerformTransfers : PerformTransfers
    {
        protected List<BankTransfersParser> SieradzParsersList;
        protected List<TransferHandle> SieradzHandlesList;
        protected List<string> ResultList = new List<string>(); 

        protected const string LogFileName = "OperationLog.txt";

        public SieradzPerformTransfers()
        {
            SieradzParsersList = GetAllParsers();
            SieradzHandlesList = GetAllHandles();
            SieradzTransferHandlesDictionary.InitialiseTransferHandleDictionaty(SieradzHandlesList);
        }

        protected sealed override List<BankTransfersParser> GetAllParsers()
        {
            var SGIC_BTP = new SieradzGenericInstanceCreator<BankTransfersParser>();
            return SGIC_BTP.CreateObjectList();
        }

        protected sealed override List<TransferHandle> GetAllHandles()
        {
            var SGIC_TH = new SieradzGenericInstanceCreator<TransferHandle>();
            return SGIC_TH.CreateObjectList();
        }

        //Można Przygotować wersję używającą ParalellProcessing i ProcessInParallel jak tu http://puu.sh/iYUDK/f1d6f76442.png
        public override void TransferAll()
        {  
            Parallel.ForEach(SieradzParsersList, NuklearesWaffenArsenal);
            WriteResultsToLogFile();
        }

        protected virtual void NuklearesWaffenArsenal(BankTransfersParser parser)
        {
            var transfers = parser.GetBankTransfers();
            Parallel.ForEach(transfers, TryToSendTransfer);
        }

        protected virtual void TryToSendTransfer(BankTransfer transfer)
        {
            var handler = SieradzTransferHandlesDictionary.GetTransferHandleByBankName(transfer.DestinationBank);
            if (handler != null) handler.SendTransfer(transfer);
            ResultList.Add(GetFormattedResult(transfer));
        }

        protected virtual string GetFormattedResult(BankTransfer transfer)
        {
            return string.Format("{0} => {1} : {2} ", transfer.SourceBank, transfer.DestinationBank,
                transfer.IsTransferSuccessful ? "Powodzenie" : "Błąd");
        }

        protected virtual void WriteResultsToLogFile()
        {
            StreamWriter logFile = new StreamWriter(SieradzBankFilesPathHolder.TransferFilesPath + LogFileName);
            ResultList.ForEach(result => logFile.WriteLine(result));
            logFile.Close();
        }
    }
}