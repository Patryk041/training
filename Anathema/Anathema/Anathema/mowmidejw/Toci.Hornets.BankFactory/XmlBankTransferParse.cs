using System.Collections.Generic;
using Toci.Hornets.BankFactory.Bank;
using Toci.Hornets.BankFactory.Models;
    namespace Toci.Hornets.BankFactory
    
    {
        public class XmlBankTransferParser : IDocumentParser<BankTransfer>
        {
            public List<BankTransfer> GetAllResults(string path)
            {
                return new List<BankTransfer>();
            }
        }
    }