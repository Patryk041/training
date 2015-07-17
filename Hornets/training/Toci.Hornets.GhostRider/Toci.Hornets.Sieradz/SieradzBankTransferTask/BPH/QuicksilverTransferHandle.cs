using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.BPH
{
    public class QuicksilverTransferHandle: TransferHandle
    {

        public QuicksilverTransferHandle()
        {
            BankName = "BPH";
        }

        protected override bool Send(BankTransfer transfer)
        {
            var outTransfer = (SieradzBankTransfer) transfer;
            string performedTransfers =

                "Historia wykonanych przelewów: \n Numer konta nadawcy przelewu: " +
                outTransfer.TransferInfo.SourceAccountNumber +
                " \n Nazwisko nadawcy: " + outTransfer.TransferInfo.SourcePersonName +
                " \n Numer konta odbiorcy przelewu: " + outTransfer.TransferInfo.DestinationAccountNumber +
                " \n Nazwisko odbiorcy: " + outTransfer.TransferInfo.DestinationPersonName +
                " \n Tytułem: " + outTransfer.TransferInfo.TransferTitle +
                " \n Kwota: " + outTransfer.TransferInfo.Amount +
                " \n Data wykonania: " + outTransfer.TransferInfo.TransferDate;
            
            
            System.IO.StreamWriter file = new System.IO.StreamWriter(SieradzBankFilesPathHolder.TransferFilesPath + @"..\BPH\QuicksilverPerformed.txt",true);
            file.WriteLine(performedTransfers);

            file.Close();
            transfer.IsTransferSuccessful = true;
            return transfer.IsTransferSuccessful;
        }
    }
}