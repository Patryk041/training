using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.TrainingThree.Xml.Entities;
using InitialTrainingLibrary.TrainingThree.Xml.Logic;
using Toci.TraininigLibrary.Common.FileParser;

namespace InitialTrainingLibrary.TrainingThree.Polimorphism
{
    public class XmlTransfersParser : TransfersParserBase
    {
        public override List<FileEntityBase> GetTransfers(string path)
        {
            XmlParser<Transfers> xmlParser = new XmlParser<Transfers>();
            var result = xmlParser.GetXmlData(path);

            List<FileEntityBase> finalResult = new List<FileEntityBase>();

            foreach (var item in result.TransfersList)
            {
                finalResult.Add(new FileEntityBase() { Account = item.Account, Surname = item.Owner, Date = Convert.ToDateTime(item.Date)});
            }

            return finalResult;
        }
    }
}
