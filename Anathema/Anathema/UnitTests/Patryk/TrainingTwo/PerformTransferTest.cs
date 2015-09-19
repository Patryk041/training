using System;
using System.Collections.Generic;
using Anathema.Patryk.TrainingTwo.Banks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Patryk.TrainingTwo
{
    [TestClass]
    public class PerformTransferTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"..//..//Patryk//TrainingTwo//Files//BankTransfersToDo.txt";

            PerfromBankTransfers perfromBankTransfers = new PerfromBankTransfers(new BanktransferLogic());

            perfromBankTransfers.PerformTransfers(path);

        }
    }
}
