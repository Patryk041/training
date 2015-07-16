using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.BankTransfersParsers;

namespace Toci.Hornets.UnitTests.Legnica.Kir
{
    [TestClass]
    public class LegnicaFileOperationTests
    {

        [TestMethod]
        public void GetFileContent_WhenFileFromDisc()
        {
            PrepareFiles();
            NordeaBankTransfersParser bankTransfersParser = new NordeaBankTransfersParser(new LegnicaFileOperation(),
                                                            @"..\..\..\Toci.Hornets.UnitTests\Legnica\Kir\Files\t1.txt");
            var banktransfers = bankTransfersParser.GetBankTransfers();

        }

        private void PrepareFiles()
        {
            LegnicaBankTransfer bankTransfer = new LegnicaBankTransfer();
            bankTransfer.DestinationBank = "Nordea";
            bankTransfer.SourceBank = "Ing";
            bankTransfer.DestinationBankNumber= "123456789";
            bankTransfer.SourceBankNumber = "987654321";
            bankTransfer.Amount = 300;
            bankTransfer.Title = "przelew testowy";
            bankTransfer.Date = new DateTime(2015,6,5);

            Random random = new Random();
            random.Next();
                StreamWriter sw = File.CreateText( @"..\..\..\Toci.Hornets.UnitTests\Legnica\Kir\Files\t1.txt");

                sw.WriteLine(bankTransfer);
                sw.Close();
        }
    }
}