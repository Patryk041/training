using System;
using System.Collections.Generic;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Zielu
{
    public class ZieluTransferFileParserFactory
    {
        private const string Ing = "int.txt";
        private const string Multibank = "multibank.txt";

        private static readonly Dictionary<string, Func<TransferFileParser>> BankDictionary = new Dictionary<string, Func<TransferFileParser>>()
        {
            {Ing,() => new ZieluingTransferFileParser()},
            {Multibank, () => new ZielumultibankTransferFileParser()}
        };
        public static TransferFileParser GetTransferFileParser(string file)
        {
            return BankDictionary.ContainsKey(file) ? BankDictionary[file]() : null;
        }

    }
}
