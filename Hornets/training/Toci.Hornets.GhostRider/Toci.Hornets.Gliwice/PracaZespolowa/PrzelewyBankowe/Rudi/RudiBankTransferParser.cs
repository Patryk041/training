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

        public RudiBankTransferParser(string path = @"..\\Didi\\DidiPrzelewy.txt")
        {
            BankFileOperation = new GliwiceFileOperation();
            string input = BankFileOperation.GetFileContent(path);
            listaPrzelewow = new List<string>(input.Split('\n'));
        }


        public override List<RudiBankTransfer> GetBankTransfers()
        {
            List<RudiBankTransfer> bankTransfers = new List<RudiBankTransfer>();

            foreach(String przelew in listaPrzelewow)
            {
                bankTransfers.Add(new RudiBankTransfer(przelew.Split(';')));
            }

            return bankTransfers;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            //zmienia ze strinka na banktransfer
            throw new NotImplementedException();
     
        }
    }
}
