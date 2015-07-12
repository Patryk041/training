using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Bytom.Pr0fes0r.TrainingTwo.PeselValidator;

namespace Toci.Hornets.UnitTests.Pr0fes0r.TrainingTwo
{
    [TestClass]
    public class PeselValidatorPr0fes0r
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pesel testPr0Fes0R = new Pesel();
            Assert.IsTrue(testPr0Fes0R.IsPeselValid("94081012391"));
        
        }
    }
}
