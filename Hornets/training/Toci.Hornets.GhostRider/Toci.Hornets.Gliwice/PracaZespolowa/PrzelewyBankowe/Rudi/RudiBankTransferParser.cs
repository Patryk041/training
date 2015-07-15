using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Rudi
{

   
    public class RudiBankTransferParser : BankTransfersParser
    {
        public List<String> listaPrzelewow{get;set;}

        public RudiBankTransferParser()
        {
            BankFileOperation = new GliwiceFileOperation();
            string input = BankFileOperation.GetFileContent("..\\Didi\\DidiPrzelewy.txt");

            listaPrzelewow = new List<string>(input.Split('\n'));

        }

        public override List<BankTransfer> GetBankTransfers()
        {
            throw new NotImplementedException();
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            //zmienia ze strinka na banktransfer
            throw new NotImplementedException();
     
        }
    }
}
