using System.Collections.Generic;
using System.Xml;
using Anathema.Patryk.TrainingTwo.Banks.Models;
using Anathema.Patryk.TrainingTwo.Banks.Parsers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Patryk.TrainingTwo
{

    [TestClass]
    public class XmlTest
    {

        [TestMethod]
        public void GetNodesFromXmlFile()
        {
            List<BankTransfer> results = new List<BankTransfer>();

            string path = @"..//..//Patryk//TrainingTwo//Files//TransfersToDo.xml";

            XmlDocument doc = new XmlDocument();

            doc.Load(path);

            XmlNodeList nList = doc.SelectNodes("/TransferList/Transfer");

            XmlNodeList elements = doc.GetElementsByTagName("Transfer");

           
            foreach (XmlNode node in elements)
            {
                XmlNodeList nodes = node.ChildNodes;

                results.Add(new BankTransfer()
                {
                    SourceBankName = nodes.Item(0).InnerText,
                    DestinationBankName = nodes.Item(1).InnerText,
                    Amount = double.Parse(nodes.Item(2).InnerText)
                });
            }

            XmlBankTransfersParser xmlBankTransfer = new XmlBankTransfersParser();
            var result = xmlBankTransfer.GetAllResults(path);



            /*
             * <TransferList>
                  <Transfer>
                      <SourceBankName>Nordea</SourceBankName>
                      <DestinationBankName>Bzwbk</DestinationBankName>
                      <Amount>3646</Amount>
                  </Transfer>
                  <Transfer>
                      <SourceBankName>Pekao</SourceBankName>
                      <DestinationBankName>Ing</DestinationBankName>
                      <Amount>6707</Amount>
                  </Transfer>
           </TransferList>
             
             */
        }
         
    }
}