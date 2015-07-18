using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Rudi
{
     class RudiBankTransfer : BankTransfer
    {
        // From - dane naku/klienta przelewajacego
        // To - dane banku/klienta docelowego
        public string FromAccountNumber{ get; set; }
        public string ToAccountNumber { get; set; }
        public string Ammount { get; set; }
        public string FromSurname { get; set; }
        public string ToSurname { get; set; }
        public string Date { get; set; }
        public string TransferTitle { get; set; }
        public string FromBank { get; set; }
        public string ToBank { get; set; }

        public RudiBankTransfer()
        {}

        public RudiBankTransfer(string[] dane)
        {
            dane[0] = FromAccountNumber;
            dane[1] = ToAccountNumber;
            dane[2] = Ammount;
            dane[3] = FromAccountNumber;
            dane[4] = ToSurname;
            dane[5] = Date;
            dane[6] = TransferTitle;
            dane[7] = FromBank;
            dane[8] = ToBank;

            DestinationBank = dane[7];
            SourceBank = dane[8];


        }

    }
}
