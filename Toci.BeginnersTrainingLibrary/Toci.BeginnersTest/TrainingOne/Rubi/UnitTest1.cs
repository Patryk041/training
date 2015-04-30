using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Rubi;

namespace Toci.BeginnersTest.TrainingOne.Rubi
{

    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            var x = new DateValidator();
            Assert.IsTrue(x.CheckDate(2012,02,29));
            //Assert.IsFalse(x.CheckDate(2012, 01, 32));

        }
    }
}
