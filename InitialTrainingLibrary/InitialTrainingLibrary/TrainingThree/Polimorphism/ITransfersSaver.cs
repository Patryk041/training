using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace InitialTrainingLibrary.TrainingThree.Polimorphism
{
    public interface ITransfersSaver
    {
        int SaveTransfers(List<FileEntityBase> transfers);
    }
}
