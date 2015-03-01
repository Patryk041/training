using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.bank.Interfaces
{
    interface IFileSection
    {
        FileEntry ReadEntry(StreamReader reader);
    }
}
