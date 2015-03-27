using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.TrainingFour.DependancyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.warrior.TrainingFour
{
    [TestClass]
    public class DepInjectionTest
    {
        [TestMethod]
        public void TestDependancyInjection()
        {
            DiTest test = new DiTest();
            test.test();
        }
    }
}
