

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Lambdas;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Linq;

namespace Toci.BeginnersTest.TrainingTwo
{
    [TestClass]
    public class TestLambdas
    {
        [TestMethod]
        public void WarriorLambdasTest()
        {
            DelegatesShowdown dsa = new DelegatesShowdown();
            //dsa.GetWhateverSet(new List<string>() {"radar", "dsafasd", "SDFASFADS"}, );
           // dsa.Showdown(new List<string>() {"radar", "dsafasd", "SDFASFADS", "dfsagsdgsfhdg"});
            dsa.LambdaShowdown(new List<string>() { "radar", "dsafasd", "SDFASFADS", "dfsagsdgsfhdg" });
        }

        [TestMethod]
        public void TestLinq()
        {
            LinqShowdown sh = new LinqShowdown();

            sh.Get("dsaf");
        }
    }
}
