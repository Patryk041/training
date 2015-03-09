using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace InitialTrainingLibrary.TrainingThree.Polimorphism
{
    public interface ITransfersParser
    {
        List<FileEntityBase> GetTransfers(string path);
    }
}
