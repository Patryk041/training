using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.S2yfr4nt
{
    interface IS2yfr4ntTransferHelper
    {
        List<string> RowFill(List<string> elements);
        TransferEntity EntityFill(List<string> elements);
    }
}
