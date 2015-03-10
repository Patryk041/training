using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Sito.Polimorphism.TransferModels;

namespace Toci.TraininigLibrary.Developers.Sito.Polimorphism.Interfaces
{
    public interface ITransferParser
    {
        List<SitoTransfer> GetTransfers(string path);
    }
}
