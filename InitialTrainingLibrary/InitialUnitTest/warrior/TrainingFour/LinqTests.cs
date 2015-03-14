using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.TrainingFour.Linq;
using InitialUnitTest.szymon93;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.warrior.TrainingFour
{
    [TestClass]
    public class LinqTests
    {
        [TestMethod]
        public void WarriorTestLinq()
        {
            WarriorLinqOperations operations = new WarriorLinqOperations();

            operations.TestLinqArray();

            operations.TestLinqDictionary();
        }
    }
}
