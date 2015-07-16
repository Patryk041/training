using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Sieradz.UCantTouchThis.JsonParser;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.Alior
{
    public class UCantTouchThisBankTransfersParser : BankTransfersParser
    {
        protected SimpleJsonParser<SieradzTransferInfo> JsonParser = new SimpleJsonParser<SieradzTransferInfo>();
        protected List<BankTransfer> BankTransfersList;
        protected const string SingleJsonLinePattern = @"\{.*}";
        protected const string BankName = "Alior";
        protected const int AccountIdentifierBeginningIndex = 2;
        protected const int AccountIdentifierLength = 4;

        public UCantTouchThisBankTransfersParser()
        {
            BankFileOperation = new SieradzFileOperation();
        }

        public override List<BankTransfer> GetBankTransfers()
        {
            return GetFilledList(BankFileOperation.GetFileContent(SieradzBankFilesPathHolder.TransferFilesPath + "Alior.json"));
        }

        protected virtual List<BankTransfer> GetFilledList(string file)
        {
            return Regex.Matches(file, SingleJsonLinePattern).Cast<Match>().Where(match => match.Success).Select(match => GetTransferEntry(match.Value)).ToList();
        } 

        protected override BankTransfer GetTransferEntry(string entry)
        {
            BankTransfer bankTransfer = new SieradzBankTransfer();
            ((SieradzBankTransfer) bankTransfer).TransferInfo =
                JsonParser.Parse(((SieradzBankTransfer) bankTransfer).TransferInfo, entry);
            SetBankNames(bankTransfer);
            return bankTransfer;
        }

        protected virtual void SetBankNames(BankTransfer bankTransfer)
        {
            bankTransfer.SourceBank = BankName;
            bankTransfer.DestinationBank = GetDestinationBankName(((SieradzBankTransfer) bankTransfer).TransferInfo);
        }

        protected virtual string GetDestinationBankName(SieradzTransferInfo transferInfo)
        {
            return ConvertNumberAccountToBankName(transferInfo.DestinationAccountNumber);
        }

        protected virtual string ConvertNumberAccountToBankName(string accountNumber)
        {
            return SieradzBankTransfersUtils.Instance.GetBankName(accountNumber.Substring(AccountIdentifierBeginningIndex, AccountIdentifierLength));
        }
    }
}