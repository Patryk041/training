using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Sito.Polimorphism.Interfaces;
using Toci.TraininigLibrary.Developers.Sito.Polimorphism.TransferModels;

namespace Toci.TraininigLibrary.Developers.Sito.Polimorphism
{
    public abstract class SitoTransferParserBase: ITransferParser
    {
        public abstract List<SitoTransfer> GetTransfers(string path);
    }
}
