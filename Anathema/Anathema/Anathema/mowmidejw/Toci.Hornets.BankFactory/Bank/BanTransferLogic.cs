     using System;
    using System.Collections.Generic;
    using Toci.Hornets.BankFactory.Bank.Abstract;
    using Toci.Hornets.BankFactory.Bank.Handlers;
    using Toci.Hornets.BankFactory.Models;
    namespace Toci.Hornets.BankFactory.Bank

    {
        public class BanktransferLogic : AbstractFactoryWithFuncAsKey<string, IDocumentParser<BankTransfer>>, IBanktransferLogic
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
