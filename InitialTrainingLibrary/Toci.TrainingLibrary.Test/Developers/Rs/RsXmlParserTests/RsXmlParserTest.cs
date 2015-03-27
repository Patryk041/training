using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.RS.XmlParser;

namespace Toci.TrainingLibrary.Test.Developers.Rs.RsXmlParserTests
{
    [TestClass]
    public class RsXmlParserTest
    {
        [TestMethod]
        public void CanParserReadXmlData()
        {
            const string path =
                @"C:\Users\roman.suska\Documents\Visual Studio 2013\Projects\training\InitialTrainingLibrary\Toci.TraininigLibrary\xmldata\transfer_2015-03-13_12345678901_rs.xml";
            var target = new RsXmlTransfersParser();

            var result = target.GetTransfersList(path);

            Assert.IsNotNull(result);
            Assert.AreEqual("123456789", result[0].AccountNumber);
            Assert.AreEqual("Bank Polnocny", result[0].BankName);
            Assert.AreEqual("2015-03-13", result[0].Date);
            Assert.AreEqual("Jan Kowalski", result[0].Owner);
            Assert.AreEqual("456789123", result[0].SourceAccountNumber);
            Assert.AreEqual("150.00", result[0].Sum);
        }
    }
}
