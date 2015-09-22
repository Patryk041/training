using System;
using System.Collections.Generic;
using Anathema.Patryk.TrainingTwo.Banks.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.Models;
using Anathema.Patryk.TrainingTwo.Banks.Parsers;
using Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract;
using Anathema.Patryk.TrainingTwo.Utils;

namespace Anathema.Patryk.TrainingTwo.Banks
{

    public class BanktransferLogic : AbstractFactoryWithFuncAsKey<string,IDocumentParser<BankTransfer>>,IBanktransferLogic
    {     
        public BanktransferLogic()
        {
            Dictonary = new Dictionary<Func<string, bool>, Func<IDocumentParser<BankTransfer>>>()
            {
                { text => text.EndsWith(".txt"), () => new TxtBankTransferParser()   },
                { text => text.EndsWith(".xml"), () => new XmlBankTransferParser()   }
            };  
        }


        public List<BankTransfer> GetAllBanktransfers(string path)
        {
            IDocumentParser<BankTransfer> documentParser = GetElement(path);
            return documentParser.GetAllResults(path);
        }
    }
}