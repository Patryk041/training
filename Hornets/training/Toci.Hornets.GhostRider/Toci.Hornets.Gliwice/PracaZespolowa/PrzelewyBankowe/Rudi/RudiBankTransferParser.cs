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
#warning RUDI Poprawa funkcji 
        public RudiBankTransferParser(string path = @"..\\Didi\\DidiPrzelewy.txt") //co to ma być?! :P czemu mój plik jest jako parametr domyślny? 
        {
            BankFileOperation = new GliwiceFileOperation();
            string input = BankFileOperation.GetFileContent(path);
            listaPrzelewow = new List<string>(input.Split('\n'));
        }


        public override List<BankTransfer> GetBankTransfers()    
        {
            // To jest funkcja napisana przez Bartka, Bartek dostraczył architekturę, którą my dziedziczym NIE MOŻEMY jej zmieniać 
            //bo nam typ nie odpowiada, która ona zwraca. 
            List<RudiBankTransfer> bankTransfers = new List<RudiBankTransfer>();

            foreach(String przelew in listaPrzelewow)
            {
                bankTransfers.Add(new RudiBankTransfer(przelew.Split(';')));
            }
            // tutaj należy robić cast na Bartka typ. 
            return null;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            //zmienia ze strinka na banktransfer
            throw new NotImplementedException();
            //do soboty pola które łapią wyjątki mają być zaimplementowane albo chociaż napisany byle jaki returnn 
            //tak aby na testach nie sypało Bartkowi 
        }
    }
}
