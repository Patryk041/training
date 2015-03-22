using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.IEnumerableShowdown;

namespace Toci.BeginnersTest.TrainingOne
{
    [TestClass]
    public class EnumerableTestWarrior
    {
        [TestMethod]
        public void TestEnumerableByWarrior()
        {
            Loop loop = new Loop();
            loop.Iterate();
        }
    }
}
