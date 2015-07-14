using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntPeselValidator;

namespace Toci.Hornets.UnitTests.S2yfr4nt.PeselVaidator
{
    [TestClass]
    public class PeselValidator
    {
        [TestMethod]
        public void TestMethod1()
        {
            S2yfr4ntPeselValidator testDate = new S2yfr4ntPeselValidator();
            Assert.IsTrue(testDate.IsPeselValid("94102210397"));
            //Assert.IsTrue(testDate.IsPeselValid("02271409862"));
            Assert.IsTrue(testDate.IsPeselValid("44051401458"));

            Assert.IsFalse(testDate.IsPeselValid("40001401358"));
            
        }
    }
}
