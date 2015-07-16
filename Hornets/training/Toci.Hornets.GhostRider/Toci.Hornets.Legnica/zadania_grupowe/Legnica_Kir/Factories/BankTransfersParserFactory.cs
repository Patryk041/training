using System;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.Michał_Zembik.FTPcs;
using Toci.Hornets.Legnica.Patryk_Stulczewski.Utils;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.BankTransfersParsers;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.Factories
{
    public class BankTransfersParserFactory : GenericFactory<ParserType,Func<FileOperation,BankTransfersParser>>
    {
        public BankTransfersParserFactory()
        {
            GenericDictionary = new Dictionary<ParserType, Func<FileOperation, BankTransfersParser>>()
            {
               {ParserType.Txt, (fileOperation) => new TxtBankTransfrsParser(fileOperation)}
            };
        }

        public IEnumerable<BankTransfersParser> GetAllParsers()
        {
            /*tutaJ pobieramy nowe pliki, wsadzamy do fileOperation
            *i z tego robimy nowy obiekt BankTransferParser
             * przekazujac mu przez konstruktor fileOperation
             * nastepnie zwracamy liste parserow
             */

            return GenericDictionary.Values;
        } 

    }
}