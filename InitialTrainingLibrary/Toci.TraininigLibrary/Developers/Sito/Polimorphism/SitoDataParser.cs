using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Sito.Polimorphism.TransferModels;

namespace Toci.TraininigLibrary.Developers.Sito.Polimorphism
{
    public class SitoDataParser:SitoTransferParserBase
    {
        public override List<SitoTransfer> GetTransfers(string path)
        {
            return SitoTranferParsersFactory.GetParser(GetExt(path).ToLower()).GetTransfers(path);
        }

        private string GetExt(string path)
        {
            return path.Substring(path.Length - 3, 3);
        }
    }
}
