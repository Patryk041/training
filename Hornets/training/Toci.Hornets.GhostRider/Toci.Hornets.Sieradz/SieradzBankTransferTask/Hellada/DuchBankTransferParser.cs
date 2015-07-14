using System.Collections.Generic;
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
            var test = _fileLoader.GetFileContent(path).DuBetterReplace();
            test.ToString();
            return default(List<BankTransfer>);

        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            entry.DuBetterReplace();
            return default(BankTransfer);

        }
    }
}