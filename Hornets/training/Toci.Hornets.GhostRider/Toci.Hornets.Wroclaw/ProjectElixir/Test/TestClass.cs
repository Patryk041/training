using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Wroclaw.ProjectElixir.Test
{
     [TestClass]
    public class TestClass
    {

        [TestMethod]
        public void CheckContent()
        {
            var Instance = BankTrasfersParsersWroclaw.getInstance(';');
            Instance.GetBankTransfers();



        }
    }
}
