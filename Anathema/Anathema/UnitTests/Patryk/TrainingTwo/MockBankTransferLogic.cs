using System.Collections.Generic;
using Anathema.Patryk.TrainingTwo.Banks.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.Models;

namespace UnitTests.Patryk.TrainingTwo
{
    public class MockBankTransferLogic : IBanktransferLogic
    {
        public List<BankTransfer> GetAllBanktransfers(string path)
        {
            return new List<BankTransfer>()
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
            };
        }
    }
}