using System.Collections.Generic;
using System.Net;
using System.Xml;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.Michał_Zembik.FTPcs;


namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.BankTransfersParsers
{
    public class BzwbkBankTransfrsParser : BankTransfersParser
    {
        public override List<BankTransfer> GetBankTransfers()
        {
<<<<<<< HEAD
            return new List<BankTransfer>();
=======
            List<BankTransfer> ListOfTransfers = new List<BankTransfer>();
            string FileFromServer = FTPcs.Get("bzwbk");
            var tab = FileFromServer.Split('\n');

            foreach (var line in tab)
            {
                ListOfTransfers.Add(GetTransferEntry(line));
            }   
            /*wczytaj caly plik do stringa
             * GetTransferEntry()
             * 
             */        
           return ListOfTransfers;
            
>>>>>>> 513dfd8b98a68935c5222bbd8ba74acccd7f90b8
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
<<<<<<< HEAD
            return new BankTransfer();
=======
            //stringa na bank transfer  
            //parser '\t' adfds dsa dsa /jakassciezka/asdsad/
            BankTransfer transfer = new BankTransfer();
            var tab = entry.Split('\t');
            transfer.SourceBank = tab[0];
            transfer.DestinationBank = tab[1];
            transfer.IsTransferSuccessful = true;
            return transfer;

>>>>>>> 513dfd8b98a68935c5222bbd8ba74acccd7f90b8
        }
    }
}