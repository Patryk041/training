using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator;

namespace InitialUnitTest.KrzysiuRysiu
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
	        DateValidator d1 = new DateValidator();
			Assert.IsTrue(d1.DateValidate(2016,2,29));
        }
    }
}
