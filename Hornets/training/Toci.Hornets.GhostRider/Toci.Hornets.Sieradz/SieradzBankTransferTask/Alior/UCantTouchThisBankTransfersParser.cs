using System.Collections.Generic;
using System.Text.RegularExpressions;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Sieradz.UCantTouchThis.JsonParser;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.Alior
{
    public class UCantTouchThisBankTransfersParser : BankTransfersParser
    {
        protected SimpleJsonParser<BankTransfer> JsonParser = new SimpleJsonParser<BankTransfer>();

        protected const string SingleLineJsonPattern = @"\{.*}";

        public UCantTouchThisBankTransfersParser()
        {
            BankFileOperation = new SieradzFileOperation();
        }

        public override List<BankTransfer> GetBankTransfers()
        {
            var bankTransferList = new List<BankTransfer>();
            var file = BankFileOperation.GetFileContent(SieradzBankFilesPathHolder.TransferFilesPath + "Alior.json");
            foreach (Match match in Regex.Matches(file, SingleLineJsonPattern))
            {
                if (match.Success)
                    bankTransferList.Add(GetTransferEntry(match.Value));
            }
            return bankTransferList;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            BankTransfer bankTransfer = new SieradzBankTransfer();
            return JsonParser.Parse(bankTransfer, entry);
        }
    }
}