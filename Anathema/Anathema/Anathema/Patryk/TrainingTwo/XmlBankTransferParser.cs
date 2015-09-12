using System.Collections.Generic;
using Anathema.Patryk.TrainingTwo.Banks;
using Anathema.Patryk.TrainingTwo.Models;

namespace Anathema.Patryk.TrainingTwo
{
    public class XmlBankTransferParser : IDocumentParser<BankTransfer>
    {
        public List<BankTransfer> GetAllResults(string path)
        {
            return new List<BankTransfer>();
        }
    }
}