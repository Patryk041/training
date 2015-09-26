using System;
using Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Patryk.TrainingTwo
{
    [TestClass]
    public class AnotherXmlTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"..//..//Patryk//TrainingTwo//Files//TransfersToDo.xml";
            AnotherXmlBankTransferParser bankTransferParser = new AnotherXmlBankTransferParser();
            var result = bankTransferParser.GetAllResults(path);
        }
    }
}
