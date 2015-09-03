using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Rzeszow.SemiRafista.KIR;
using Toci.Hornets.Rzeszow.Terry.TrainingThree.Common;

namespace Toci.Hornets.UnitTests.Rzeszow.SemiRafista.SeRaBankTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var srparser = new SeRaBankTransferParser();
            var transfers = srparser.GetBankTransfers();
            var srhandle = new SeRaTransferHandle();

            foreach (var tr in transfers.Where(tr => tr!=null))
            {
                srhandle.SeRaSendTransfers(tr);
            }
        }
    }
}
