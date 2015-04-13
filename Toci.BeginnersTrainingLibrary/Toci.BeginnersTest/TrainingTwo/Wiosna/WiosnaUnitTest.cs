using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Wiosna;

namespace Toci.BeginnersTest.TrainingTwo.Wiosna
{
    [TestClass]
    public class WiosnaUnitTest
    {
       
        [TestMethod]
        public void FileParserTest()
        {
           WiosnaFileParserING parserING = new WiosnaFileParserING();

            var parsedItemsING = 
                parserING.OpenFile(@"..\..\..\Toci.BeginnersTrainingLibrary\TrainingTwo\data\ing.txt");

            Assert.AreEqual("imie",parsedItemsING[0].Name);
            Assert.AreNotEqual("abcd",parsedItemsING[0].Name);

           WiosnaFileParserMultiBank parserMutliBank = new WiosnaFileParserMultiBank();

            var parsedItemsMultiBank =
                parserMutliBank.OpenFile(@"..\..\..\Toci.BeginnersTrainingLibrary\TrainingTwo\data\multibank.txt");

            Assert.AreEqual("imie",parsedItemsMultiBank[0].Name);
            Assert.AreNotEqual("abcd", parsedItemsMultiBank[0].Name);

        }

        [TestMethod]
        public void pathListTest()
        {
            WiosnaTransfers transfersTest = new WiosnaTransfers();

            var pathList = transfersTest.FilesList();

            Assert.AreEqual("..\\..\\..\\Toci.BeginnersTrainingLibrary\\TrainingTwo\\data\\ing.txt",pathList[0]);
            Assert.AreEqual("..\\..\\..\\Toci.BeginnersTrainingLibrary\\TrainingTwo\\data\\multibank.txt", pathList[1]);
        }


    }
}
