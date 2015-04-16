using System;
using System.Collections.Generic;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Zielu.Extensions;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Zielu
{
    public class ZieluTransferFileParserFactory
    {
        private const string Ing = "ing.txt";
        private const string Multibank = "multibank.txt";

        private static readonly Dictionary<string, Func<TransferFileParser>> BankDictionary = new Dictionary<string, Func<TransferFileParser>>()
        {
            {Ing,() => new ZieluingTransferFileParser()},
            {Multibank, () => new ZielumultibankTransferFileParser()}
        };
        public static TransferFileParser GetTransferFileParser(string file)
        {
            var name = file.GetFileName();
            var res= BankDictionary.ContainsKey(name) ? BankDictionary[name]() : new ZieluTransferFileParserDummy();
            return res;
        }
    }
}
