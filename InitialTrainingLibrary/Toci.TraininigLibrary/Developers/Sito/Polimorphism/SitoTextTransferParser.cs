using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Sito.Polimorphism.TransferModels;

namespace Toci.TraininigLibrary.Developers.Sito.Polimorphism
{
    public class SitoTextTransferParser:SitoTransferParserBase
    {
        private const char nameDelimeter = '_';
        private const char extDelimeter = '.';
        public override List<SitoTransfer> GetTransfers(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                var entries = new List<SitoTransfer>();
              
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var fileEntityBase = TextParserFactory.GetParser(GetDevName(path)).ReadEntry(line);
                    entries.Add(new SitoTransfer(){AccountNumber = fileEntityBase.Account,Date = fileEntityBase.Date.ToString(),Name = fileEntityBase.Name,Surname = fileEntityBase.Surname});


                }
                return entries;
            }
        }
        private string GetDevName(string path)
        {
            var devNamewithExt = path.Split(nameDelimeter).LastOrDefault();
            return devNamewithExt.Split(extDelimeter).FirstOrDefault().ToLower();
        }
    }
}
