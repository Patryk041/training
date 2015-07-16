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
        private readonly string[] _delimiter;
        private string _file; 

        public DidiBankTransferParser()
        {
            _BankTransfersList = new List<BankTransfer>();
            _delimiter = new string[] { "\r\n", ";" };
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
            string[] transfer = entry.Split(_delimiter[1].ToCharArray());
           
            var bankTransfer = new DidiBankTransfer();
            bankTransfer.Information = new DidiInformationTransfer();
            bankTransfer.SourceBank = transfer[0];
            bankTransfer.Information.NameClient = transfer[1];
            bankTransfer.Information.Title = transfer[2];
            bankTransfer.Information.Amount = transfer[3];
            bankTransfer.Information.AccountClient = transfer[4];
            bankTransfer.Information.DateTransfer = transfer[5];
            bankTransfer.Information.NameRecipe = transfer[6];
            bankTransfer.Information.AccountRecipe = transfer[7];
            bankTransfer.DestinationBank = transfer[8];

            DidiFactoryTransfer.SendBank(bankTransfer, bankTransfer.DestinationBank); 
            return bankTransfer;
        }

        private List<string> CutBankTransfers(string file)
        {
            //wszystkie przelewy
            List<string> transfers = file.Split(_delimiter[0].ToCharArray()).ToList();
            List<string> newTransfers = new List<string>();
            foreach (var item in transfers)
            {
                if (item != String.Empty)
                {
                 newTransfers.Add(item);  
                }
            }
            return newTransfers; 
        }
        
    }
}
