using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.Michał_Zembik.FTPcs;
using BankTransfer = Toci.Hornets.GhostRider.Kir.BankTransfer;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.TransferHandles
{
    public class NordeaTransferHandle : TransferHandle
    {
        /*private FTPcs cs;
        public NordeaTransferHandle(FTPcs cs)
        {
            this.cs = cs;
        }

        public NordeaTransferHandle()
        {
            BankName = "Nordea";
        }

        protected override bool Send(BankTransfer transfer)
        {
            int x = GetHashCode();

            string str = transfer.SourceBank + GetHashCode();
            cs.Send(transfer);
            //cs.Send();//ftp:://cos.pl/+/SorceBank+/GetHashCode();
            return true;
            
        }*/
        protected override bool Send(BankTransfer transfer)
        {
            return true;
        }
    }
}