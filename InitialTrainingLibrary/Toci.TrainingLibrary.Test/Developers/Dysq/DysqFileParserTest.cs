using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Dysq.Bin;
using Toci.TraininigLibrary.Developers.Dysq.Bin.Products;
using Toci.TraininigLibrary.Developers.Dysq.FileParser;
using Toci.TraininigLibrary.Developers.Dysq.Polymorphism;
using Toci.TraininigLibrary.Developers.Dysq.XML;

namespace Toci.TrainingLibrary.Test.Developers.Dysq
{
    [TestClass]
    public class DysqFileParserTest
    {
        [TestMethod]
        public void TestDysqFileParser()
        {

            DysqFileDetailParser parser = new DysqFileDetailParser();
           

          //string filePath = @"E:\Szkolenia\InitialTrainingLibrary\Toci.TraininigLibrary\data\transfer_2015-03-02_987654321_dysq.txt";
          string filePath = @"..\..\..\Toci.TraininigLibrary\data\transfer_2015-03-02_987654321_dysq.txt";
          //string filePath = @"F:\self\projects\training\InitialTrainingLibrary\Toci.TraininigLibrary\data\transfer_2015-03-02_987654321_dysq.txt";

            List<string> lines = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {   while(!reader.EndOfStream)
                lines.Add(reader.ReadLine());

            }

           var test = parser.ReadEntry(lines[0]);

            Assert.AreEqual(test.Name, "Mateusz");
        }

        [TestMethod]
        public void TestDysqShopItemName()
        {
            DysqPurchase purchase = new DysqPurchase(2,220.00, BootsKind.Sandals,false);
           // purchase.SetName(BootsKind.Sandals);
           //var name= purchase.Name();
            var testPurchase = purchase;
            
        }

        [TestMethod]
        public void TestDysqXmlParser()
        {
            DysqXmlTransferParser xmlDysqParser= new DysqXmlTransferParser();
            string dysqPath = @"E:\Szkolenia\InitialTrainingLibrary\Toci.TraininigLibrary\xmldata\transfer_2015-03-10_09876543210_dysq.xml";

            var list = xmlDysqParser.GetTransfers(dysqPath);



        }
        [TestMethod]
        public void TestDysqPolymorphism()
        {
            string dysqPath = @"E:\Szkolenia\InitialTrainingLibrary\Toci.TraininigLibrary\Developers\Dysq\DataForTest\transfer_2015_03_02_987654321_dysq.txt";
            DysqTransferParserBase parseMyFileDysq = new DysqTxtFileParser();

            var test = parseMyFileDysq.GetTransfers(dysqPath);
        }
    }
}
