using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.Patryk_Stulczewski.Utils;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.interfaces;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.Factories
{
    public class BankTransfersParserGenerator : IBankTransferParserGenerator
    {
       
        public IEnumerable<BankTransfersParser> GetAllParsers()
        {
            /*tutaJ pobieramy nowe pliki, wsadzamy do fileOperation
            *i z tego robimy nowy obiekt BankTransferParser
             * przekazujac mu przez konstruktor fileOperation
             * nastepnie zwracamy liste parserow
             */
            return null;
        } 

    }
}