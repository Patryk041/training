using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Sieradz.SieradzBankTransferTask.SieradzBankUtils;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.Hellada
{
    public class DuchBankTransferParser :BankTransfersParser
    {
        private const string path = @"..\..\..\Toci.Hornets.Sieradz\SieradzBankTransferTask\BankTransfersFiles\0000Hellada.txt";
        private readonly SieradzFileOperation _fileLoader;

        public DuchBankTransferParser()
        {
            _fileLoader = new SieradzFileOperation();
        }

        public override List<BankTransfer> GetBankTransfers()
        {
            var fileContent = _fileLoader.GetFileContent(path).DuBetterReplace();
            var transfersArray = Regex.Split(fileContent, "€€€€");

            return (from transfer in transfersArray where transfer.Any() select GetTransferEntry(transfer)).ToList();

        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            var transferInfoArray = entry.Split('€');

            return new BankTransfer()
            {
                DestinationBank = SieradzBankTransfersUtils.Instance.GetBankName(transferInfoArray[2].Substring(2, 4)),
                SourceBank = SieradzBankTransfersUtils.Instance.GetBankName(transferInfoArray[1].Substring(2, 4)),
                IsTransferSuccessful = transferInfoArray[1].Substring(2, 4) == transferInfoArray[2].Substring(2, 4)
            };

        }
    }
}