using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Terry.TrainingThree.TerryBank
{
    public class TerryBankTransferHandle : TransferHandle
    {
        public TerryBankTransferHandle()
        {
            BankName = "TerryBank";
        }

        protected override bool Send(BankTransfer transfer)
        {

            //nie działa...


            using ( StreamWriter writer = new StreamWriter("c:/TOCI/test.txt", true))
            {
               writer.Write("{0}.{1}.destNr.destName.srcNr.srcName.amount.title.{2}/", transfer.DestinationBank,
            transfer.SourceBank, transfer.IsTransferSuccessful);
                
            }
          
            return true;
        }
    }
}