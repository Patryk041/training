using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Robson.RobsonFileParser;
using Toci.TraininigLibrary.Common.FileParser;
namespace Toci.TrainingLibrary.Test.Developers.Robson
{
    [TestClass]
    public class RobsonsFileParserTest
    {
        [TestMethod]
        public void TestRowSplitting()
        {
            RobsonFileDetails testDetails = new RobsonFileDetails();

            string name = "Name";
            string surname = "Surname";
            DateTime date = new DateTime(2015, 12, 12);
            string account = "12345678909";
            string title = "billTitle";
            float money = 1000000.0F;

            RobsonFileEntity entity = (RobsonFileEntity)testDetails.ReadEntry("Name\tSurname\t12-12-2015\t12345678909\tbillTitle\t1000000,00");
            Assert.IsTrue(name == entity.Name);
            Assert.IsTrue(surname == entity.Surname);
            Assert.IsTrue(date == entity.Date);
            Assert.IsTrue(account == entity.Account);
            Assert.IsTrue(title == entity.Title);
            Assert.IsTrue(money == entity.Money);
        }

        [TestMethod]
        public void TestFileParser()
        {
            RobsonFileDetails mainDetails = new RobsonFileDetails();

            RobsonsFileParser mainFileParser = new RobsonsFileParser(mainDetails);

            var rowsCollection = RobsonsFileReader.GetLine(@"..\..\..\Toci.TraininigLibrary\data\transfer_2015-03-17_61666662266_Robson.txt");
            foreach(var row in rowsCollection)
            {
                RobsonFileEntity parsedData = (RobsonFileEntity)mainFileParser.GetParsedData(row);
                Assert.IsTrue(parsedData.Name == "Jan");
                Assert.IsTrue(parsedData.Surname == "Kowalski");
                Assert.IsTrue(parsedData.Account == "12345678909");
                Assert.IsTrue(parsedData.Title == "Twarzowe");
                Assert.IsTrue(parsedData.Money == 9999999);
            }
        }

    }
}
