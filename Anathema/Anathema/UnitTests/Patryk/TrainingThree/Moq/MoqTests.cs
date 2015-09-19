using System.Collections.Generic;
using Anathema.Patryk.TrainingTwo.Banks;
using Anathema.Patryk.TrainingTwo.Banks.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTests.Patryk.TrainingThree.Moq
{
    [TestClass]
    public class MoqTests
    {
        [TestMethod]
        public void test()
        {
            string path = @"..//..//Patryk//TrainingTwo//Files//BankTransfersToDo.txt";

            Mock<IBanktransferLogic> mock = new Mock<IBanktransferLogic>();
            mock.Setup(item => item.GetAllBanktransfers(It.IsAny<string>())).Returns(new List<BankTransfer>()
            {
                new BankTransfer()
                {
                    DestinationBankName = "Bzwbk",
                    SourceBankName = "Nordea"
                },
                new BankTransfer()
                {
                    DestinationBankName = "Bzwbk",
                    SourceBankName = "Nordea"
                },
                new BankTransfer()
                {
                    DestinationBankName = "Bzwbk",
                    SourceBankName = "Nordea"
                },
                new BankTransfer()
                {
                    DestinationBankName = "Bzwbk",
                    SourceBankName = "Nordea"
                },
                new BankTransfer()
                {
                    DestinationBankName = "Bzwbk",
                    SourceBankName = "Nordea"
                }
            });

            PerfromBankTransfers perfromBankTransfers = new PerfromBankTransfers(mock.Object);
            perfromBankTransfers.PerformTransfers(null);

        }
    }
}