using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.RS.FileParser;

namespace Toci.TrainingLibrary.Test.Developers.Rs
{
    [TestClass]
    public class RsFileDetailParserTest
    {
        [TestMethod]
        public void TestRsJsonFile()
        {
            var parser = new RsFileDetailsParser();


            const string dataLine = "{\"name\": \"Roman\",\"surname\": \"Suska\",\"datetime\": \"2015-03-05\",\"number\": \"1234567890\"}";

            var result = parser.ReadEntry(dataLine);

            Assert.AreEqual("Roman", result.Name);
            Assert.AreEqual("Suska", result.Surname);
            Assert.AreEqual(new DateTime(2015, 3, 5), result.Date);
            Assert.AreEqual("1234567890", result.Account);
        }
    }
}
