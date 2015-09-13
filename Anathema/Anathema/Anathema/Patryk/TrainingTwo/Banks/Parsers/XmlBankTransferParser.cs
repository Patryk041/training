using System.Collections.Generic;
using Anathema.Patryk.TrainingTwo.Banks.Models;
using Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract;

namespace Anathema.Patryk.TrainingTwo.Banks.Parsers
{
    public class XmlBankTransferParser : IDocumentParser<BankTransfer>
    {
        //jak ktos chce to moze napisac logike do wyciagania przelewow z xmla
        public List<BankTransfer> GetAllResults(string path)
        {
            return new List<BankTransfer>();
        }
    }
}