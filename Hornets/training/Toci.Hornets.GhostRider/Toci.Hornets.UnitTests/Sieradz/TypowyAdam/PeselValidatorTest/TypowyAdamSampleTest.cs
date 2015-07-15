using System;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.Filip_Sokolowski.homeWork.peselValidator;
using Toci.Hornets.Sieradz.SieradzBankTransferTask.mBank;
using Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks;

namespace Toci.Hornets.UnitTests.Sieradz.TypowyAdam.PeselValidatorTest
{
    [TestClass]
    public class TypowyAdamSampleTest
    {
                  

        [TestMethod]
        public void TestMethod1()
        {

            var test = new TypowyAdamTransferHandle();
            test.SendTransfer(new BankTransfer());
        }

    }
}
