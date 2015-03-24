using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.ReferenceTypes;

namespace Toci.BeginnersTest.TrainingOne
{
    [TestClass]
    public class CorRefTypesTest
    {
        [TestMethod]
        public void TestChorRefTypes()
        {
            CorLogic logic = new CorLogic();
            logic.Fire();
        }
    }
}
