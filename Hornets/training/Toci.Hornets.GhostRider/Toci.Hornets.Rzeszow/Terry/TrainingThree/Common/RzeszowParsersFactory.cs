using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Rzeszow.Chojnecki.Kir;
using Toci.Hornets.Rzeszow.Foonesh.TrainingThree;
using Toci.Hornets.Rzeszow.Terry.TrainingThree.TerryBank;

namespace Toci.Hornets.Rzeszow.Terry.TrainingThree.Common
{
    public static class RzeszowParsersFactory
    {
        private static readonly Dictionary<string, BankTransfersParser> ParsersDictionary = new Dictionary<string, BankTransfersParser>
        {
            {"TerryBank", new TerryBankTransfersParser()},
            {"Foonesh", new BankTransfersParserFoonesh()},
            {"Andrzej", new AndrzejBankTransfersParser()}
        };
        public static BankTransfersParser GetHandle(string bank)
        {
            return ParsersDictionary.ContainsKey(bank) ? ParsersDictionary[bank] : null;
        }
    }
}