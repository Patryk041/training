using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Anathema.Patryk.TrainingTwo.Banks.Models;

namespace Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract
{
    public class AnotherXmlBankTransferParser : IDocumentParser<BankTransfer>
    {
        public List<BankTransfer> GetAllResults(string path)
        {
            XmlDocument xmlDocument = new XmlDocument();

            xmlDocument.Load(path);

            XmlNodeList elements = xmlDocument.GetElementsByTagName("Transfer");
            List<BankTransfer> results = new List<BankTransfer>();

            foreach (XmlNode xmlNode in elements)
            {
                XmlNodeList nodeList = xmlNode.ChildNodes;

                results.Add(new BankTransfer
                {
                    SourceBankName = nodeList.Item(0).InnerText,
                    DestinationBankName = nodeList.Item(1).InnerText,
                    Amount = double.Parse(nodeList.Item(2).InnerText)
                });
            }
            return results;
        }
    }
}


//Otworz plik xml

//dla kazdego elementu w liscie 

//typ generyczny 

//utworz obiekt klasy Bank Transfer

// abstrakcja , interfejs , typ generyczny 

