using System;
using System.Collections.Generic;
using Anathema.Patryk.TrainingTwo.Banks.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.Models;
using Anathema.Patryk.TrainingTwo.Banks.Parsers;
using Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract;
using Anathema.Patryk.TrainingTwo.Utils;

namespace Anathema.Patryk.TrainingTwo.Banks
{

    //klasa która jest odpowiedzialna za dostarczenie listy przelewów na podstawie otrzymanej sciezki do pliku

    public class BanktransferLogic : AbstractFactoryWithFuncAsKey<string,IDocumentParser<BankTransfer>>,IBanktransferLogic
    {
       
        public BanktransferLogic()
        {
            
            //jak ktos chce to moze dopisac parser dla innego rozszerzenia
            Dictonary = new Dictionary<Func<string, bool>, Func<IDocumentParser<BankTransfer>>>()
            {

                //jako text otrzymujemy sciezke do pliku, sprawdzamy, czy konczy sie txt.
                //Jezeli tak, to zwracamy TxtBankTransferParser

                { text => text.EndsWith(".txt"), () => new TxtBankTransferParser()   },
                { text => text.EndsWith(".xml"), () => new XmlBankTransferParser()   }
            };  
        }


        public List<BankTransfer> GetAllBanktransfers(string path)
        {
            //z fabryki na podstawie rozszerzenia otrzymujemy parser, który dostarczy nam listę przelewów

            IDocumentParser<BankTransfer> documentParser = GetElement(path);
            return documentParser.GetAllResults(path);
        }
    }
}