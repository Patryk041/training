using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe
{
    public class DidiBankTransferParser : BankTransfersParser
    {
        private List<BankTransfer> _BankTransfersList;
        private readonly char[] _delimiter;
        private string _file; 

        public DidiBankTransferParser()
        {
            _BankTransfersList = new List<BankTransfer>();
            _delimiter = new char[] {'\n', ';'};
        }

        public override List<BankTransfer> GetBankTransfers()
        {
            GliwiceFileOperation fileOperation = new GliwiceFileOperation();
           _file = fileOperation.GetFileContent(@"C:\\Users\\Dominika\\Documents\\SourceTree\\TOCI\\Szkolenie\\Hornets\\training\\Toci.Hornets.GhostRider\\Toci.Hornets.Gliwice\\PracaZespolowa\\PrzelewyBankowe\\Didi\\DidiPrzelewy.txt");
           
            List<string> transfersList = CutBankTransfers(_file);
            foreach (var transfer in transfersList)
            {
                _BankTransfersList.Add(GetTransferEntry(transfer)); 
            }
            return _BankTransfersList;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            //metoda dla jednego przelwu 
            string[] transfer = entry.Split(_delimiter[1]);

            var bankTransfer = new DidiBankTransfer();
            bankTransfer.SourceBank = transfer[0];
            bankTransfer.NameClient = transfer[1];
            bankTransfer.Title = transfer[2];
            bankTransfer.Amount = transfer[3];
            bankTransfer.AccountClient = transfer[4];
            bankTransfer.DateTransfer = transfer[5];
            bankTransfer.NameRecipe = transfer[6];
            bankTransfer.AccountRecipe = transfer[7];
            bankTransfer.SourceBank = transfer[8];

            return bankTransfer;
        }

        private List<string> CutBankTransfers(string file)
        {
            //wszystkie przelewy
            List<string> transfers = file.Split(_delimiter[0]).ToList();
            return transfers; 
        }
        
    }
}
