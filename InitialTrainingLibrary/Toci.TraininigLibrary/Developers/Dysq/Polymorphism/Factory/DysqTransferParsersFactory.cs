using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Dysq.XML;
using Toci.TraininigLibrary.Developers.Dysq.XMLBase;

namespace Toci.TraininigLibrary.Developers.Dysq.Polymorphism.Factory
{
    public class DysqTransferParsersFactory
    {
        private static Dictionary<string, Func<DysqTransfersParserBase>> dysqParsersFactory = 
            new Dictionary<string, Func<DysqTransfersParserBase>>()
            {
                {"xml",()=> new DysqXmlTransferParser()},
                {"txt",()=> new DysqTxtFileParser()},
            };

        public static DysqTransfersParserBase ChoseTransfer(string ext)
        {
                return dysqParsersFactory.ContainsKey(ext)? dysqParsersFactory[ext]() :null;
        }

    }
}
