using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Santi;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.S2yfr4nt
{
    class S2yfr4ntTransferFileParserFactory
    {
        private const string ING = "ing.txt";
        private const string MULTIBANK = "multibank.txt";

        public static Dictionary<string, Func<TransferFileParser>> FilesListDelegate = new Dictionary<string, Func<TransferFileParser>>
        {
            {ING, () => new S2yfr4ntIngTransferFileParser()},
            {MULTIBANK, () => new S2yfr4ntMultiBankTransferFileParser()},
        };
    }
}
