using System;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Matwie
{
    class TransferFileParserFactory
    {
        public static TransferFileParser CreateTransferFileParser(string path)
        {
            if (path.Contains("ing.txt"))
                return new IngTransferFileParser();
            else if (path.Contains("multibank.txt"))
                return new MultibankTransferFileParser();
            else 
                throw new Exception();
        }
    }
}
