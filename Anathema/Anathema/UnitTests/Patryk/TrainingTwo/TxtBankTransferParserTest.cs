using System.Collections.Generic;
using Anathema.Patryk.TrainingTwo.Banks;
using Anathema.Patryk.TrainingTwo.Banks.Handlers;
using Anathema.Patryk.TrainingTwo.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Patryk.TrainingTwo
{
    [TestClass]
    public class TxtBankTransferParserTest
    {

        [TestMethod]
        public void test()
        {
            string path = @"..//..//Patryk//TrainingTwo//Files//BankTransfersToDo.txt";

            TxtParser<BankTransfer> txtBankTransferParser = new TxtBankTransferParser();

            List<BankTransfer> list =  txtBankTransferParser.GetAllResults(path);
        }

         
    }
}