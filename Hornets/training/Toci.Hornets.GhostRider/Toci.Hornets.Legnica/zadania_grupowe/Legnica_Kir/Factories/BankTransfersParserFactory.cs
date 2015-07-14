using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.Patryk_Stulczewski.Utils;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.Factories
{
    public class BankTransfersParserFactory : GenericFactory<ParserType,BankTransfersParser>
    {
        public BankTransfersParserFactory()
        {
            GenericDictionary = new Dictionary<ParserType, BankTransfersParser>()
            {
               //tutaj parsery np xmla, txt 
            };
        }

        public IEnumerable<BankTransfersParser> GetAllParsers()
        {
            return GenericDictionary.Values;
        } 

    }
}