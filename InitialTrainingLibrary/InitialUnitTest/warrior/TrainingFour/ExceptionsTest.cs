using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.TrainingFour.Exceptions;
using InitialUnitTest.szymon93;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.warrior.TrainingFour
{
    [TestClass]
    public class ExceptionsTest
    {
        [TestMethod]
        public void TestExceptions()
        {
            WarriorExceptionsFun fun = new WarriorExceptionsFun();

            fun.FunWithExceptions();
        }
    }
}
