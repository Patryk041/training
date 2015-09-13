using System;
using System.Collections.Generic;
using System.Linq;
using Anathema.Patryk.TrainingTwo.Banks.Models;
using Anathema.Patryk.TrainingTwo.Banks.Parsers;
using Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Patryk.TrainingTwo
{
    [TestClass]
    public class FactoriesWithFuncAsKeyTest
    {
        Dictionary<Func<string, bool>, Func<IDocumentParser<BankTransfer>>> dictionary =
                new Dictionary<Func<string, bool>, Func<IDocumentParser<BankTransfer>>>()
                {
                    { s => s.EndsWith(".txt") , () => new TxtBankTransferParser()},
                    { s => s.EndsWith(".xml") , () => new XmlBankTransferParser() }
                };

        [TestMethod]
        public void FetchValueFromDictWhenBadFileExtensionTest()
        {

            Assert.IsNotNull(GetDocumentParser("plik.txt"));
            Assert.IsNotNull(GetDocumentParser("plik.xml"));
        } 

        [TestMethod]
        public void FetchValueFromDictWhenGoodFileExtensionTest()
        {
            Assert.IsNull(GetDocumentParser("plik.ddd"));
        }

        private IDocumentParser<BankTransfer> GetDocumentParser(string path)
        {
            Func<IDocumentParser<BankTransfer>> value = dictionary.FirstOrDefault(item => item.Key(path)).Value;
            return value != null ? value() : null;
        }
    }
}