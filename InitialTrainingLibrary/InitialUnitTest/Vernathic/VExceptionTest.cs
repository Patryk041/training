using System;
using System.Text;
using System.Collections.Generic;
using InitialTrainingLibrary.Vernathic.Cyrograph;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.Vernathic
{
    [TestClass]
    public class VExceptionTest
    {
        [TestMethod]
        public void VExceptionTest1()
        {
            VernathicException ex = new VernathicException();
            DateTime date = new DateTime(2015,05,10);
            Assert.AreEqual(ex.DeadLineTime(),date);
        }
    }
}
