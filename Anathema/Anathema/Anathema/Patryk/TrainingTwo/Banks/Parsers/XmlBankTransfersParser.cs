using System.Xml;
using Anathema.Patryk.TrainingTwo.Banks.Models;

namespace Anathema.Patryk.TrainingTwo.Banks.Parsers
{
    public class XmlBankTransfersParser : XmlParser<BankTransfer>
    {
        public XmlBankTransfersParser()
            : base("Transfer")
        {
        }

        protected override BankTransfer GetResult(XmlNodeList nodes)
        {
            return new BankTransfer
            {
                SourceBankName = nodes.Item(0).InnerText,
                DestinationBankName = nodes.Item(1).InnerText,
                Amount = double.Parse(nodes.Item(2).InnerText)
            };
        }
    }
}