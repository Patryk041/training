
using System.Collections.Generic;
using System.IO;
using Toci.BeginnersTrainingLibrary.TrainingOne.Factory;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Matwie
{
    class TransferFileParserFactory
    {
        public static TransferFileParser CreateTransferFileParser()
        {
            var files = Directory.GetFiles(@"..\data\");

            return new IngTransferFileParser();
        }
    }
}
