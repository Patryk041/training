using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.KSebal.traningThreeHomework
{
   public class KsebalBankTransfer:BankTransfer
    {
        public string SenderTransferName { get; set; }
        public string SenderTransferSurname { get; set; }
        public int SenderAccountNumber { get; set; }
        public string ConsumerTransferName { get; set; }
        public string ConsumerTransferSurname { get; set; }
        public int ConsumerAccountNumber { get; set; }

        public KsebalBankTransfer(string[] words)
        {
            SenderTransferName = words[0];
            SenderTransferSurname = words[1];
            SourceBank = words[2];
            SenderAccountNumber = int.Parse(words[3]);
            ConsumerTransferName = words[4];
            ConsumerTransferSurname = words[5];
            DestinationBank = words[6];
            ConsumerAccountNumber = int.Parse(words[7]);
        }

       

    }
}
