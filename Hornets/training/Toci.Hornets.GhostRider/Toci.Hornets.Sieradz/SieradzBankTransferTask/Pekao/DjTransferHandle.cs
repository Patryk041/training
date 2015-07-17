using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.Pekao
{
    public class DjTransferHandle : TransferHandle
    {
        public DjTransferHandle()
        {
            BankName = "Pekao";
        }

        protected override bool Send(BankTransfer transfer)
        {
            var subject = "Transfer to " + BankName;
            var body = CreateMessageForTransfer(transfer);
            transfer.IsTransferSuccessful = true; //DjEmailSender.SendEmail(subject, body);
            return transfer.IsTransferSuccessful;
        }

        private static string CreateMessageForTransfer(BankTransfer transfer)
        {
            return "Transfer pieniędzy z banku " + transfer.SourceBank + " do naszego banku, " + transfer.DestinationBank + ".\n";
        }
    }
}