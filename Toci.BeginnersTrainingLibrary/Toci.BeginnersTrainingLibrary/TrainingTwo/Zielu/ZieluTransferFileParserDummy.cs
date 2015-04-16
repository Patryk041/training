using System;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Zielu
{
    class ZieluTransferFileParserDummy: TransferFileParser
    {
        protected override TransferEntity GetRow(string row)
        {
            throw new Exception("Nie ma takiego banku");
        }
    }
}
