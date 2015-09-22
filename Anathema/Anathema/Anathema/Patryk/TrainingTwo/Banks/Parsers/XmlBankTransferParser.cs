using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Anathema.Patryk.TrainingTwo.Banks.Models;
using Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract;

namespace Anathema.Patryk.TrainingTwo.Banks.Parsers
{
    public class XmlBankTransferParser : IDocumentParser<BankTransfer>
    {
        private XmlDocument _xmlDocument;

        public XmlBankTransferParser()
        {
            _xmlDocument = new XmlDocument();
        }

        public List<BankTransfer> GetAllResults(string path)
        {
            return GetEntries(path).Select(GetBankTransfer).ToList();
        }

        protected List<XmlNode> GetEntries(string path)
        {
            _xmlDocument.Load(path);
            return _xmlDocument.GetElementsByTagName("Transfer").Cast<XmlNode>().ToList();
        }

        private BankTransfer GetBankTransfer(XmlNode xmlNode)
        {
            XmlNodeList nodes = xmlNode.ChildNodes;

            return new BankTransfer()
            {
                SourceBankName = nodes.Item(0).InnerText,
                DestinationBankName = nodes.Item(1).InnerText,
                Amount = double.Parse(nodes.Item(2).InnerText)
            };
        }
    }
}